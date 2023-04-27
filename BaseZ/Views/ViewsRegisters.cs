using BaseZ.Controller;
using BaseZ.Models;
using BaseZ.Singleton;
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
    public partial class ViewsRegistersView : Form
    {
        public List<Register> registers_ = new List<Register>();
        private Form menu_;
        private string _cellValue = String.Empty;
        
        public ViewsRegistersView()
        {
            this.registers_ = ConfigurationSingleton.Instance.Registers;
            InitializeComponent();
            //showRegisters();
        }

        private void showRegisters()
        {
            if (this.registers_.Count.Equals(0)) {
                Console.WriteLine("vasio");
            }
            /*foreach (var register in this.registers_)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.ContextMenuStrip();
                this.dataGridView1.Rows.Add(register.toStringArray);
            }*/

            for (int i = 0; i < this.registers_.Count; i++)
            {
                this.dataGridView1.Rows.Add(this.registers_[i].toStringArray);
                DataGridViewRow row = this.dataGridView1.Rows[i];


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

        private void ViewsRegisters_Load(object sender, EventArgs e)
        {
            showRegisters();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            _cellValue = dataGridView1[0, e.RowIndex].Value.ToString();
            this.contextMenuStrip1.Show(MousePosition);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToLower())
            {
                case "add":
                    Console.WriteLine("annadir "+this._cellValue);
                    break;
                case "delete":
                    Console.WriteLine("Eliminar " + this._cellValue);
                    break;
            }

        }
    }
}
