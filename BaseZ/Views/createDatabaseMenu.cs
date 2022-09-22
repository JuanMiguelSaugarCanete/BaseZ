using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BaseZ.Models;
using Newtonsoft.Json;

namespace BaseZ
{
    public partial class createDatabaseMenu : Form
    {
        public createDatabaseMenu()
        {
            InitializeComponent();
        }

        private async void createDatabase(object sender, EventArgs e)
        {
            string password = "123456789";
            string name = "databaseProof2";
            string path = @"C:\Users\JuanMiguel\source\repos\BaseZ\BaseZ\Databases\";
            string pathComplete = path + name + ".json";
            List<Register> _registers = new List<Register>();
            _registers.Add(new Register("1", "data", "data@data.es", "dataData", "123456", "www.google.es"));
            _registers.Add(new Register("2", "data", "data@data.es", "dataData", "123456", "www.google.es"));
            string jsonBD = JsonConvert.SerializeObject(_registers, Formatting.Indented);
            File.WriteAllText(pathComplete, jsonBD);
            Encrytp encrytp = new Encrytp(password, path);
            encrytp.EncryptFile(new FileInfo(pathComplete));
            File.Delete(pathComplete);

        }


        private void DecryptFile(object sender, EventArgs e)
        {
            string password = "123456789";
            string name = "databaseProof2";
            string path = @"C:\Users\JuanMiguel\source\repos\BaseZ\BaseZ\Databases\";
            string pathComplete = path + name + ".enc";
            string pathCompleteJSON = path + name + ".json";
            Encrytp encrytp = new Encrytp(password, path);
            encrytp.DecryptFile(new FileInfo(pathComplete));
            File.Delete(pathComplete);
            string jsonString = File.ReadAllText(pathCompleteJSON);
            List<Register> _registers = JsonConvert.DeserializeObject<List<Register>>(jsonString);
            foreach (Register item in _registers)
            {
                Console.WriteLine(item.Id);
            }
            File.Delete(pathCompleteJSON);
        }

        public static void Error(string error) { 
            MessageBox.Show(error);
        }
    }
}
