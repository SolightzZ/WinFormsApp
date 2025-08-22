using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp2
{
    internal class DBConnection
    {
        public static SqlConnection northwindConnect()
        {
            string ConnectionString = "Data Source=LAPTOP-2JJ054OC\\MSSQL; Initial Catalog=Northwind; Integrated Security=True; Encrypt=False;";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
