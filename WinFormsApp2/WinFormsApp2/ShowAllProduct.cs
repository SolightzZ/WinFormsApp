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
    public partial class ShowAllProduct : Form
    {
        public ShowAllProduct()
        {
            InitializeComponent();
        }

        private void ShowAllProduct_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.northwindConnection();
            string sql = "SELECT * FROM Products";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvResult.DataSource = dt;
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
