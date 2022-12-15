using BaseZ.Models;
using BaseZ.Views.CRUDRegister;
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
    public partial class ViewsRegisters : Form
    {
        public List<Register> registers_ = new List<Register>();
        private Form menu_;
        public ViewsRegisters(Form menu, List<Register> registers)
        {
            this.menu_ = menu;
            this.registers_ = registers;
            InitializeComponent();
            showRegisters();
        }

        private void showRegisters()
        {
            int separationCont = 200;
            if (this.registers_.Count.Equals(0)) {
                Console.WriteLine("vasio");
            }
            foreach (var register in this.registers_)
            {
                this.dataGridView1.Rows.Add(register.toStringArray);
            }

        }

        private void ViewsRegisters_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void addRegister(object sender, EventArgs e)
        {
            CreateRegister create = new CreateRegister(this);
            create.Show();
        }
    }
}
