using BaseZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseZ.Models
{
    public class EncrytpSingleton
    {
        private static EncrytpSingleton _instance = new EncrytpSingleton();
        private List<Register> passwords = new List<Register>();


        private EncrytpSingleton()
        {

        }

        public static EncrytpSingleton Instance
        {
            get { return _instance; }
        }

        internal List<Register> Passwords { get => passwords; set => passwords = value; }
    }
}

