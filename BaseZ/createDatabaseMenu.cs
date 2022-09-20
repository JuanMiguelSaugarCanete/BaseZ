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
            string name = "databaseProof";
            string path = @"C:\Users\JuanMiguel\source\repos\BaseZ\BaseZ\Databases\";
            string pathComplete = path + name+".json";
            Database bd = new Database().createOneDatabase(name,password);
            string jsonBD = JsonConvert.SerializeObject(bd);
            File.WriteAllText(pathComplete, jsonBD);


        }
    }
}
