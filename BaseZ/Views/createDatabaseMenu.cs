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
using BaseZ.Util;

namespace BaseZ
{
    public partial class CreateDatabaseMenu : Form
    {
        private Form menu_;
        public CreateDatabaseMenu(Form menu)
        {
            this.menu_ = menu;
            InitializeComponent();
        }

        private async void createDatabase(object sender, EventArgs e)
        {
            string password = this.bdPasswd.Text.ToString();
            string name = this.bdName.Text.ToString();
            string pathComplete = Configuration.Configuration.DEFAULT_PATH + name + ".json";
            string jsonBD = JsonSerializerBaseZ.SerializeRegisters(Database.initDatabase().Registers);
            File.WriteAllText(pathComplete, jsonBD);
            Encrytp encrytp = new Encrytp(password);
            encrytp.EncryptFile(new FileInfo(pathComplete));
            File.Delete(pathComplete);

        }

        public static void Error(string error) { 
            MessageBox.Show(error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.menu_.Show();
            this.Close();

        }

        private void CreateDatabaseMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
