using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; 
using System.Data;

namespace WinFormsApp2
{
    internal class DBConnection
    {
        public static SqlConnection northwindConnection()
        {
             string connectionString = "Data Source=LAPTOP-2JJ054OC\\SQLEXPRESS; Initial catalog=Northwind; Integrated Security=true; Encrypt=false";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;    
        }
    }
}
