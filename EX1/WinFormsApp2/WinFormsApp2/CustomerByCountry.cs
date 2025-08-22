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
    public partial class CustomerByCountry : Form
    {
        public CustomerByCountry()
        {
            InitializeComponent();
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerByCountry_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.northwindConnection();
            string sql = "SELECT Distinct Country From Customers Order By Country ASC";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCountry.DataSource = dt;
            cboCountry.DisplayMember = "Country";
            cboCountry.ValueMember = "Country";

            conn.Close();

            DataRow row = dt.NewRow();
            row[0] = "All Countries";
            dt.Rows.Add(row);
        }

        private void tbtnShow_Click(object sender, EventArgs e)
        {
            string country = cboCountry.SelectedValue.ToString();
            if (country == "All Countries")
            {
                showCustomersByCountry();
            }
            else
            {
                showCustomersByCountry(country);
            }

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //สร้างเมธอด เเสดงลูกค้าตามประเทศที่เลือก
        public void showCustomersByCountry(string country)
        {
            SqlConnection conn = DBConnection.northwindConnection();
            string sql = "SELECT * FROM Customers WHERE Country = @Country";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Country", country);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvResult.DataSource = dt;
            conn.Close();
        }

        //overloading เทธอท showCustomersByCountry()
        public void showCustomersByCountry()
        {
            SqlConnection conn = DBConnection.northwindConnection();
            string sql = "SELECT * FROM Customers";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvResult.DataSource = dt;
            conn.Close();
        }
    }
}
