using BaseZ.Constants;
using BaseZ.Controller;
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
        private DatabaseController databaseController_;
        private ViewController viewController_;
        public OpenDatabase(Form menu)
        {
            this.menu_ = menu;
            InitializeComponent();
        }
        public OpenDatabase()
        {
            this.databaseController_ = new DatabaseController();
            this.viewController_ = new ViewController();
            InitializeComponent();
        }
        private void DecryptFile(object sender, EventArgs e)
        {
            string password = this.bdPasswd.Text.ToString();
            string name = this.bdName.Text.ToString();

            this.databaseController_.OpenDatabase(new Database(name, password));
            this.viewController_.openView(ViewsConstant.AC_OPEN_VIEW, ViewsConstant.AC_OPEN_VIEW_REGISTER,this);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.viewController_.backMenuBtn(this);
        }

        private void OpenDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.viewController_.closeApp();
        }

        private void SelectorDB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog().Equals(DialogResult.OK)) {
                this.bdName.Text = openFileDialog1.FileName;
            }
        }
    }
}
