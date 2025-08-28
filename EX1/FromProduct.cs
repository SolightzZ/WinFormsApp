using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EX1
{
    public partial class FromProduct : Form
    {
        public FromProduct()
        {
            InitializeComponent();
        }

        void showSupplierCountry()
        {
            SqlConnection conn = DBConnection.NorthwindConnect();
            String sql = "SELECT DISTINCT Country FROM Suppliers ORDER BY Country";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboSupplierCountry.DataSource = dt;
            cboSupplierCountry.DisplayMember = "Country";
            cboSupplierCountry.ValueMember = "Country";

            conn.Close();
        }

        void showShipCountry()
        {
            SqlConnection conn = DBConnection.NorthwindConnect();
            String sql = "SELECT DISTINCT ShipCountry FROM Orders ORDER BY ShipCountry";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboShipCountry.DataSource = dt;
            cboShipCountry.DisplayMember = "ShipCountry";
            cboShipCountry.ValueMember = "ShipCountry";

            conn.Close();
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

        void showResult()
        {
            SqlConnection conn = DBConnection.NorthwindConnect();
            String sql = "SELECT ProductID, ProductName, SUM(UnitPrice * Quantity) As Sale_Volumes \r\nFROM ProductByVolume\r\nWHERE Country = @supplierCountry  AND YEAR(OrderDate) =  @saleYear AND ShipCountry = @shipCountry\r\nGROUP BY ProductID, ProductName";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@supplierCountry", cboSupplierCountry.Text);
            cmd.Parameters.AddWithValue("@shipCountry", cboShipCountry.Text);
            cmd.Parameters.AddWithValue("@saleYear", cboYear.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;

            conn.Close();

            dgvResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvResult.Columns[2].DefaultCellStyle.Format = "#,##0.00";
        }

        private void FromProduct_Load(object sender, EventArgs e)
        {
            showSupplierCountry();
            showShipCountry();
            showYear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showResult();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSupplierCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboShipCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
