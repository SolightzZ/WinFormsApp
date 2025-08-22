using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.northwindConnect();
            string sql = "SELECT * FROM Products WHERE Unitprice BETWEEN @MinOrice AND @MaxPrice";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@MinOrice", txtMaxPrice.Txt);
            cmd.Parameters.AddWithValue("@MaxPrice", txtMinPrice.Txt);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResultShow.DataSource = dt;
            conn.Close();
        }
    }
}
