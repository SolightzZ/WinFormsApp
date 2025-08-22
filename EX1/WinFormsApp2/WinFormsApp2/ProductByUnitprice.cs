using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class ProductByUnitprice : Form
    {
        public ProductByUnitprice()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductByUnitprice_Load(object sender, EventArgs e)
        {

        }

        private void txtMinPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.northwindConnection();
            string sql = "SELECT * FROM Products WHERE Unitprice BETWEEN @MinPrice AND @MaxPrice";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@MinPrice", txtMinPrice.Text);
            cmd.Parameters.AddWithValue("@MaxPrice", txtMaxPrice.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResault.DataSource = dt;
            conn.Close();
        }
    }
}
