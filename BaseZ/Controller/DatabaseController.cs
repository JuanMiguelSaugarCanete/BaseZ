using BaseZ.Constants;
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
    public class DatabaseController
    {

        public async void createDatabase(Database db) {
            string pathComplete = Configuration.Configuration.DEFAULT_PATH + db.NameDatabase + ".json";
            string jsonBD = JsonSerializerBaseZ.SerializeRegisters(Database.initDatabase().Registers);
            File.WriteAllText(pathComplete, jsonBD);
            Encrytp encrytp = new Encrytp(db.PasswordDatabase);
            encrytp.EncryptFile(new FileInfo(pathComplete));
            File.Delete(pathComplete);
            this.OpenDatabase(db);
        }

        public async void OpenDatabase(Database db) {
            string pathComplete = db.NameDatabase;
            string pathCompleteJSON;
            if (!db.NameDatabase.Contains(@"\"))
            {
                pathComplete = Configuration.Configuration.DEFAULT_PATH + db.NameDatabase + Configuration.Configuration.FORMAT_DB;
            }
            else
            {

                string[] stringName = db.NameDatabase.Split('\\');
                db.NameDatabase = stringName[stringName.Length - 1].Replace(Configuration.Configuration.FORMAT_DB, "");
            }

            ConfigurationSingleton.Instance.PathDatabase = pathComplete;
            pathCompleteJSON = Configuration.Configuration.DEFAULT_PATH + db.NameDatabase + Configuration.Configuration.FORMAT_JSON;
            Encrytp encrytp = new Encrytp(db.PasswordDatabase);
            encrytp.DecryptFile(new FileInfo(pathComplete));
            //File.Delete(pathComplete);
            string jsonString = File.ReadAllText(pathCompleteJSON);
            List<Register> registersJSON = JsonSerializerBaseZ.DeserializeRegister(jsonString);
            File.Delete(pathCompleteJSON);
            ConfigurationSingleton.Instance.Registers = registersJSON;
        }
    }
}
