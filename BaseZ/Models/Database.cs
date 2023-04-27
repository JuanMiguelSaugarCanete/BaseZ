using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseZ.Models
{
    public class Database
    {
        private string _nameDatabase;
        private string _passwordDatabase;
        private List<Register> _registers;

        public Database()
        {
            this._registers = new List<Register>();
        }
        public Database(string nameDatabase, string passwordDatabase)
        {
            this.NameDatabase = nameDatabase;
            this.PasswordDatabase = passwordDatabase;
            this._registers = new List<Register>();
        }

        public List<Register> Registers { get => _registers; set => _registers = value; }
        public string NameDatabase { get => _nameDatabase; set => _nameDatabase = value; }
        public string PasswordDatabase { get => _passwordDatabase; set => _passwordDatabase = value; }

        public static Database initDatabase() { 
            Database db = new Database();
            Encrytp encrytp = new Encrytp();
            db.Registers.Add(encrytp.EncryptPassword(new Register("1", "data", "data@data.es", "dataData", "www.google.es","Hola1")));
            db.Registers.Add(encrytp.EncryptPassword(new Register("2", "data", "data@data.es", "dataData", "www.google.es", "Hola2")));
            return db;
        }
    }
}
