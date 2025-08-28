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
    public partial class WorkShop8 : Form
    {
        public WorkShop8()
        {
            InitializeComponent();
        }

        void showYear()
        {
            SqlConnection conn = DBConnection.NorthwindConnect();
            String sql = "SELECT DISTINCT Year(OrderDate) AS YearSale FROM Orders ORDER BY YEAR(OrderDate)";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboYear.DataSource = dt;
            cboYear.DisplayMember = "YearSale";
            cboYear.ValueMember = "YearSale";

            conn.Close();
        }

        void ShowCategory()
        {
            SqlConnection conn = DBConnection.NorthwindConnect();
            String sql = "SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryName";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";

            conn.Close();

        }

        void showResult()
        {
            SqlConnection conn = DBConnection.NorthwindConnect();
            SqlCommand cmd = new SqlCommand("WorkShop8", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Categories", cboCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@Year", cboYear.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;

            conn.Close();
            dgvResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResult.Columns[2].DefaultCellStyle.Format = "#,##0.00";
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WorkShop8_Load(object sender, EventArgs e)
        {
            showYear();
            ShowCategory();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showResult();
        }
    }
}
