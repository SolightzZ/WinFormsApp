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
    public partial class WorkShop7 : Form
    {
        public WorkShop7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        //----------------------------------------------------------------------------------------
        void showResult()
        {
            SqlConnection conn = DBConnection.NorthwindConnect();
            SqlCommand cmd = new SqlCommand("CountProductsByCategory", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();

            dgvResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WorkShop7_Load(object sender, EventArgs e)
        {
            showResult();
        }
    }
}
