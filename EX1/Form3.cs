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

namespace EX1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvResultShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.NorthwindConnect(); 
            string sql = "SELECT * FROM Products WHERE UnitPrice BETWEEN @MinPrice AND @MaxPrice";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@MinPrice", txtMinPrice.Text); 
            cmd.Parameters.AddWithValue("@MaxPrice", txtMaxPrice.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResultShow.DataSource = dt;
            conn.Close();
        }

    }
}
