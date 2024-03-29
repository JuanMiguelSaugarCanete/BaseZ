﻿using BaseZ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseZ.Controller;

namespace BaseZ.Views.CRUDRegister
{
    public partial class CreateRegister : Form
    {
        private ViewsRegistersView _viewsRegisters;
        public CreateRegister(ViewsRegistersView viewsRegisters)
        {
            InitializeComponent();
            this._viewsRegisters = viewsRegisters;
        }
        public CreateRegister()
        {
            InitializeComponent();
        }


        private void createRegister(object sender, EventArgs e)
        {
            RegisterController controller = new RegisterController();
            controller.createRegister(
                new Register(this.textBoxName.Text.ToString(),
                this.textBoxEmail.Text.ToString(),
                this.textBoxUserName.Text.ToString(),
                this.textBoxURL.Text.ToString(),
                this.textBoxPw.Text.ToString())
            );
            this.Close();
        }
    }
}
