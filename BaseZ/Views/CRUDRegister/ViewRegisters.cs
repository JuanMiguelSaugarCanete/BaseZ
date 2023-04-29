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

namespace BaseZ.Views.CRUDRegister
{
    public partial class ViewRegisters : Form
    {
        private List<Register> registers_;
        private string cellValue_;
        private ViewController viewController_;
        private RegisterController registerController_;
        public ViewRegisters()
        {
            this.cellValue_ = String.Empty;
            this.viewController_ = new ViewController();
            registerController_ = new RegisterController();
            InitializeComponent();
        }

        private void contextMenuStripRegisters_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case ViewsConstant.CMS_DELETE:
                    Console.WriteLine("annadir " + this.cellValue_);
                    break;
                case ViewsConstant.CMS_ADD:
                    this.viewController_.openView(ViewsConstant.AC_OPEN_VIEW, ViewsConstant.AC_OPEN_VIEW_CREATE_REGISTER,null);
                    break;
                case ViewsConstant.CMS_MODIFY:
                    Console.WriteLine("annadir " + this.cellValue_);
                    break;
                case ViewsConstant.CMS_OPEN_URL:
                    Console.WriteLine("annadir " + this.cellValue_);
                    break;
                case ViewsConstant.CMS_COPY_USERNAME:
                    Console.WriteLine("annadir " + this.cellValue_);
                    break;
                case ViewsConstant.CMS_COPY_NAME:
                    Console.WriteLine("annadir " + this.cellValue_);
                    break;
                case ViewsConstant.CMS_COPY_PASSWORD:
                    Console.WriteLine("annadir " + this.cellValue_);
                    break;
                
            }
        }

        private void dataGridViewRegisters_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            cellValue_ = dataGridViewRegisters[0, e.RowIndex].Value.ToString();
            this.contextMenuStripRegisters.Show(MousePosition);
        }

        private void ViewRegisters_Load(object sender, EventArgs e)
        {
            showRegisters();
        }
        private void showRegisters()
        {
            this.dataGridViewRegisters.Rows.Clear();
            this.registers_ = ConfigurationSingleton.Instance.Registers;
            if (this.registers_.Count > 0) {
                for (int i = 0; i < this.registers_.Count; i++)
                {
                    this.dataGridViewRegisters.Rows.Add(this.registers_[i].toStringArray);
                    DataGridViewRow row = this.dataGridViewRegisters.Rows[i];
                }
            }
        }
    }
}
