using BaseZ.Models;
using BaseZ.Singleton;
using BaseZ.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseZ.Views
{
    public partial class OpenDatabase : Form
    {
        private Form menu_;
        public OpenDatabase(Form menu)
        {
            this.menu_ = menu;
            InitializeComponent();
        }

        private async void DecryptFile(object sender, EventArgs e)
        {
            string password = this.bdPasswd.Text.ToString();
            string name = this.bdName.Text.ToString();
            string pathComplete = Configuration.Configuration.DEFAULT_PATH + name + ".enc";
            ConfigurationSingleton.Instance.PathDatabase = pathComplete;
            string pathCompleteJSON = Configuration.Configuration.DEFAULT_PATH + name + ".json";
            Encrytp encrytp = new Encrytp(password);
            encrytp.DecryptFile(new FileInfo(pathComplete));
            //File.Delete(pathComplete);
            string jsonString = File.ReadAllText(pathCompleteJSON);
            List<Register> registersJSON = JsonSerializerBaseZ.DeserializeRegister(jsonString);
            File.Delete(pathCompleteJSON);
            ViewsRegisters viewsRegisters = new ViewsRegisters(this.menu_, registersJSON);
            viewsRegisters.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.menu_.Show();
            this.Close();

        }

        private void OpenDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
