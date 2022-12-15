using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseZ.Models
{
    internal class Database
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
            this._nameDatabase = nameDatabase;
            this._passwordDatabase = passwordDatabase;
            this._registers = new List<Register>();
        }

        public List<Register> Registers { get => _registers; set => _registers = value; }

        public static Database initDatabase() { 
            Database db = new Database();
            Encrytp encrytp = new Encrytp();
            db.Registers.Add(encrytp.EncryptPassword(new Register("1", "data", "data@data.es", "dataData", "www.google.es","Hola1")));
            db.Registers.Add(encrytp.EncryptPassword(new Register("2", "data", "data@data.es", "dataData", "www.google.es", "Hola2")));
            return db;
        }
    }
}
