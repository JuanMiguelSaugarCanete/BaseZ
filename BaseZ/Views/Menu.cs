using BaseZ.Constants;
using BaseZ.Controller;
using BaseZ.Models;
using BaseZ.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseZ.Views
{
    public partial class Menu : Form
    {
        private ViewController viewController_;
        public Menu()
        {
            InitializeComponent();
            this.viewController_ = new ViewController();
            ConfigurationSingleton.Instance.MenuForm = this;
            ConfigurationSingleton.Instance.BtnBaack = false;
        }

        private void create_Click(object sender, EventArgs e)
        {
            this.viewController_.openView(ViewsConstant.AC_OPEN_VIEW, ViewsConstant.AC_OPEN_VIEW_CREATE_DB,null);
        }

        private void open_Click(object sender, EventArgs e)
        {
            this.viewController_.openView(ViewsConstant.AC_OPEN_VIEW, ViewsConstant.AC_OPEN_VIEW_OPEN_DB,null);
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
