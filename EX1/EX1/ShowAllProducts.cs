using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EX1
{
    public partial class ShowAllProducts : Form
    {
        public ShowAllProducts()
        {
            InitializeComponent();
        }

        private void ShowAllProducts_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.NorthwindConnect();
            string sql = "SELECT * FROM Products";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult2.DataSource = dt;
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
