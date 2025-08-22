using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Workshop1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void workshop2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void workshop4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerByCountry frm = new CustomerByCountry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void helpsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void workshop5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductByCategory PC = new ProductByCategory();
            PC.MdiParent = this;
            PC.Show();
        }

        private void workshop6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromProduct fromProduct = new FromProduct();
            fromProduct.MdiParent = this;
            fromProduct.Show();
        }
    }
}
