using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void workshopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void workshop3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductByUnitprice frm = new ProductByUnitprice();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerByCountry frm = new CustomerByCountry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
