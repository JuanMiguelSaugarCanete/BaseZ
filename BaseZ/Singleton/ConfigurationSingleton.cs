using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseZ.Singleton
{
    public class ConfigurationSingleton
    {
        private ConfigurationSingleton() { }
        private static ConfigurationSingleton _instance = new ConfigurationSingleton();

        private string pathDatabase;
        public static ConfigurationSingleton Instance
        {
            get { return _instance; }
        }

        public string PathDatabase{ get => pathDatabase; 
            set => pathDatabase = value; }

       
    }
}
