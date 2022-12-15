using BaseZ.Models;
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
        private ViewsRegisters _viewsRegisters;
        public CreateRegister(ViewsRegisters viewsRegisters)
        {
            InitializeComponent();
            this._viewsRegisters = viewsRegisters;
        }

       

        private void createRegister(object sender, EventArgs e)
        {
            RegisterController controller = new RegisterController();
            Register register = controller.createRegister(
                new Register(this.textBoxName.Text.ToString(),
                this.textBoxEmail.Text.ToString(),
                this.textBoxUserName.Text.ToString(),
                this.textBoxURL.Text.ToString(),
                this.textBoxPw.Text.ToString())
            );
            this._viewsRegisters.dataGridView1.Rows.Add(register.toStringArray);
            this.Close();
        }
    }
}
