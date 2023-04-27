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
using BaseZ.Controller;
using BaseZ.Constants;
using BaseZ.Singleton;

namespace BaseZ
{
    public partial class CreateDatabaseMenu : Form
    {
        private Form menu_;
        private DatabaseController databaseController_;
        private ViewController viewController_;
        public CreateDatabaseMenu(Form menu)
        {
            this.menu_ = menu;
            InitializeComponent();
            this.databaseController_ = new DatabaseController();
            this.viewController_ = new ViewController();
        }
        public CreateDatabaseMenu()
        {
            InitializeComponent();
            this.databaseController_ = new DatabaseController();
            this.viewController_ = new ViewController();
        }
        private void createDatabase(object sender, EventArgs e)
        {
            string password = this.bdPasswd.Text.ToString();
            string name = this.bdName.Text.ToString();
            this.databaseController_.createDatabase(new Database(name, password));
            this.Close();
            this.viewController_.openView(ViewsConstant.AC_OPEN_VIEW, ViewsConstant.AC_OPEN_VIEW_REGISTER);

        }

        public static void Error(string error) { 
            MessageBox.Show(error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.viewController_.openView(ViewsConstant.AC_OPEN_VIEW, ViewsConstant.AC_BACK_TO_MENU);
            this.Close();

        }

        private void CreateDatabaseMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
