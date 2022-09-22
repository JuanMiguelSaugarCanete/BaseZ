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
    }
}
