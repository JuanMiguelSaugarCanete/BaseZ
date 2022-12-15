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

namespace BaseZ.Views
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void create_Click(object sender, EventArgs e)
        {
            CreateDatabaseMenu createDB = new CreateDatabaseMenu(this);
            createDB.Show();
            this.Hide();
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenDatabase openDB = new OpenDatabase(this);
            openDB.Show();
            this.Hide();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
