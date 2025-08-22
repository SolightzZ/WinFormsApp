using Microsoft.Data.SqlClient;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string strconn = "Data Source=LAPTOP-2JJ054OC; Initial catalog=Northwind; Integrated Security=true; Encrypt=false";

        SqlConnection con;

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strconn);
            con.Open();

            string sql = "SELECT * FROM Customers";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvResult.DataSource = dt;
            con.Close();
        }
    }
}
