using BaseZ.Models;
using BaseZ.Singleton;
using BaseZ.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseZ.Controller
{
    public class RegisterController
    {

        public Register createRegister(Register register) {
            Encrytp encrytp = new Encrytp();
            encrytp.EncryptPassword(register);
            encrytp.DecryptFile(new FileInfo(ConfigurationSingleton.Instance.PathDatabase));
            string pathTemp = ConfigurationSingleton.Instance.PathDatabase.Replace(".enc", ".json");
            string jsonString = File.ReadAllText(pathTemp);
            List<Register> registersJSON = JsonSerializerBaseZ.DeserializeRegister(jsonString);
            register.Id = Guid.NewGuid().ToString();
            registersJSON.Add(register);
            string jsonBD = JsonSerializerBaseZ.SerializeRegisters(registersJSON);
            File.WriteAllText(pathTemp, jsonBD);
            encrytp.EncryptFile(new FileInfo(pathTemp));
            File.Delete(pathTemp);
            return register;
        }

        public string generateID(List<Register> registers) {
            string id = Guid.NewGuid().ToString();
            
            for (int i = 0; i < registers.Count; i++)
            {
                if (registers[i].Id.Equals(id))
                {
                    id = Guid.NewGuid().ToString();
                    i = 0;
                }
            }
            return id;
        }
    }
}
