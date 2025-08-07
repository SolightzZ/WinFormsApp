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
    public partial class ProductByCategory : Form
    {
        public ProductByCategory()
        {
            InitializeComponent();
        }

        private void ProductByCategory_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.NorthwindConnect();

            string sql = "SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryName ASC";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";

            conn.Close();

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "All Categories";
            dt.Rows.Add(row);

            cboCategory.SelectedIndex = cboCategory.Items.Count - 1;
            ShowProducts();
        }

        void ShowProducts()
        {
            SqlConnection conn = DBConnection.NorthwindConnect();
            String sql = "SELECT * FROM Products";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();
        }

        void ShowProducts(int cid)
        {
            SqlConnection conn = DBConnection.NorthwindConnect();

            String sql = "SELECT * FROM Products WHERE CategoryID = @categoryID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@categoryID", cid);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();
        }

        private void tbtnShow_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cboCategory.SelectedValue);
            if (cid == 0)
            {
                ShowProducts();
            }
            else
            {
                ShowProducts(cid);
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
