using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    internal class DBConnection
    {
        public static SqlConnection NorthwindConnect()
        {
        string connectionString = "Data Source=LAPTOP-2JJ054OC; Initial catalog=Northwind; Integrated Security=true; Encrypt=false";
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        return conn;    
        }

        internal static SqlConnection northwindConnect()
        {
            throw new NotImplementedException();
        }
    }
}
