using BaseZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseZ.Singleton
{
    public class ConfigurationSingleton
    {
        private ConfigurationSingleton() { }
        private static ConfigurationSingleton _instance = new ConfigurationSingleton();

        private string pathDatabase_;
        private Form menuForm_;
        private List<Register> registers_;
        private bool btnBaack;
        public static ConfigurationSingleton Instance
        {
            get { return _instance; }
        }

        public string PathDatabase{ get => pathDatabase_; 
            set => pathDatabase_ = value; }

        public Form MenuForm
        {
            get => menuForm_;
            set => menuForm_ = value;
        }
        public List<Register> Registers { get => registers_; set => registers_ = value; }
        public bool BtnBaack { get => btnBaack; set => btnBaack = value; }
    }
}
