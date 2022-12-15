
using System;

using System.IO;

using System.Security.Cryptography;


namespace BaseZ.Models
{
    class Encrytp
    {
        readonly CspParameters _cspp = new CspParameters();
        RSACryptoServiceProvider _rsa;
        private string _key;
        private string _EncrFolder;
        private string _DescrFolder;
        private byte[] Key_;
        private byte[] IV_;
        public Encrytp()
        {
            this._DescrFolder = Configuration.Configuration.DEFAULT_PATH;
            this._EncrFolder = Configuration.Configuration.DEFAULT_PATH;
            this._key = Configuration.Configuration.PWD;
            createKey();
        }
        public Encrytp(string key)
        {
            this._key = key;
            Configuration.Configuration.PWD = key;
            this._DescrFolder = Configuration.Configuration.DEFAULT_PATH;
            this._EncrFolder = Configuration.Configuration.DEFAULT_PATH; 
            createKey();
        }

        private void createKey()
        {
            _cspp.KeyContainerName = _key;
            _rsa = new RSACryptoServiceProvider(_cspp)
            {
                PersistKeyInCsp = true
            };

        }

        private static Aes generateKeyIV() { 
            Aes aes = Aes.Create();
            aes.Key = Convert.FromBase64String("0c2e1qMxOgZqDvMHyBVN1E==");
            aes.IV = Convert.FromBase64String("0c2e1qMxOgZqDvMHyBVN1E==");
            return aes;
        }
        public string Key { get => _key; set => _key = value; }
        public string EncrFolder { get => _EncrFolder; set => _EncrFolder = value; }
        public string DescrFolder { get => _DescrFolder; set => _DescrFolder = value; }

        public void EncryptFile(FileInfo file)
        {
            // Create instance of Aes for
            // symmetric encryption of the data.
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            // Use RSACryptoServiceProvider to
            // encrypt the AES key.
            // rsa is previously instantiated:
            //    rsa = new RSACryptoServiceProvider(cspp);
            byte[] keyEncrypted = _rsa.Encrypt(aes.Key, false);

            // Create byte arrays to contain
            // the length values of the key and IV.
            int lKey = keyEncrypted.Length;
            byte[] LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            byte[] LenIV = BitConverter.GetBytes(lIV);

            // Write the following to the FileStream
            // for the encrypted file (outFs):
            // - length of the key
            // - length of the IV
            // - ecrypted key
            // - the IV
            // - the encrypted cipher content

            // Change the file's extension to ".enc"
            string outFile =
                Path.Combine(_EncrFolder, Path.ChangeExtension(file.Name, ".enc"));

            using (var outFs = new FileStream(outFile, FileMode.Create))
            {
                outFs.Write(LenK, 0, 4);
                outFs.Write(LenIV, 0, 4);
                outFs.Write(keyEncrypted, 0, lKey);
                outFs.Write(aes.IV, 0, lIV);

                // Now write the cipher text using
                // a CryptoStream for encrypting.
                using (var outStreamEncrypted =
                    new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                {
                    // By encrypting a chunk at
                    // a time, you can save memory
                    // and accommodate large files.
                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (var inFs = new FileStream(file.FullName, FileMode.Open))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count);
                            bytesRead += blockSizeBytes;
                        } while (count > 0);
                    }
                    outStreamEncrypted.FlushFinalBlock();
                }
            }
        }

        public void DecryptFile(FileInfo file)
        {
            // Create instance of Aes for
            // symmetric decryption of the data.
            Aes aes = Aes.Create();

            // Create byte arrays to get the length of
            // the encrypted key and IV.
            // These values were stored as 4 bytes each
            // at the beginning of the encrypted package.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            // Construct the file name for the decrypted file.
            string outFile =
                Path.ChangeExtension(file.FullName.Replace("Encrypt", "Decrypt"), ".json");

            // Use FileStream objects to read the encrypted
            // file (inFs) and save the decrypted file (outFs).
            using (var inFs = new FileStream(file.FullName, FileMode.Open))
            {
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

                // Convert the lengths to integer values.
                int lenK = BitConverter.ToInt32(LenK, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                // Determine the start postition of
                // the ciphter text (startC)
                // and its length(lenC).
                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                // Create the byte arrays for
                // the encrypted Aes key,
                // the IV, and the cipher text.
                byte[] KeyEncrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

                // Extract the key and IV
                // starting from index 8
                // after the length values.
                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(KeyEncrypted, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);
                Directory.CreateDirectory(this._DescrFolder);
                
                
                // Use RSACryptoServiceProvider
                // to decrypt the AES key.
                byte[] KeyDecrypted = null;
                bool correctPassword = true;
                try
                {
                    KeyDecrypted = _rsa.Decrypt(KeyEncrypted, false);
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error al desencriptar" + e);

                    correctPassword = false;
                    CreateDatabaseMenu.Error("La contraseña es erronea");
                }
                if (correctPassword)
                {
                    // Decrypt the key.
                    ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                    // Decrypt the cipher text from
                    // from the FileSteam of the encrypted
                    // file (inFs) into the FileStream
                    // for the decrypted file (outFs).
                    using (var outFs = new FileStream(outFile, FileMode.Create))
                    {
                        int count = 0;
                        int offset = 0;

                        // blockSizeBytes can be any arbitrary size.
                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];

                        // By decrypting a chunk a time,
                        // you can save memory and
                        // accommodate large files.

                        // Start at the beginning
                        // of the cipher text.
                        inFs.Seek(startC, SeekOrigin.Begin);
                        using (var outStreamDecrypted =
                            new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                        {
                            do
                            {
                                count = inFs.Read(data, 0, blockSizeBytes);
                                offset += count;
                                outStreamDecrypted.Write(data, 0, count);
                            } while (count > 0);

                            outStreamDecrypted.FlushFinalBlock();
                        }
                    }
                }

            }
        }

        public Register EncryptPassword(Register register) {
            if (register.PasswordDesencrypt == null || register.PasswordDesencrypt.Length<=0) {
                throw new ArgumentNullException("Password dont exits");
            }
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = generateKeyIV().Key;
                aesAlg.IV = generateKeyIV().IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(register.PasswordDesencrypt);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            register.PasswordEncrypt = encrypted;
            EncrytpSingleton.Instance.Passwords.Add(register);
            return register;
        }

        public Register DecryptPassword(Register register) {
            
                if (register.PasswordEncrypt == null || register.PasswordEncrypt.Length <= 0) {
                    throw new ArgumentNullException("cipherText");
                }
                string passwordDecrypt = null;
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = generateKeyIV().Key;
                    aesAlg.IV = generateKeyIV().IV;

                    // Create a decryptor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    // Create the streams used for decryption.
                    using (MemoryStream msDecrypt = new MemoryStream(register.PasswordEncrypt))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {

                                // Read the decrypted bytes from the decrypting stream
                                // and place them in a string.
                                passwordDecrypt = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
                register.PasswordDesencrypt = passwordDecrypt;
            return register;
        }
    }
    
}
