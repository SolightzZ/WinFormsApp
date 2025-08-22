using Microsoft.Data.SqlClient;
using System.Data;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
         SqlConnection conn = DBConnection.northwindConnection();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection Opened Successfully");
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }
    }
}
