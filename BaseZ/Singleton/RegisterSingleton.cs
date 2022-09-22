using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseZ.Singleton
{
    public sealed class RegisterSingleton
    {
        private readonly static RegisterSingleton _instance = new RegisterSingleton();
        private RegisterSingleton() { 
        
        }

        public static RegisterSingleton Instance { 
            get { return _instance; }
        }
    }
}
