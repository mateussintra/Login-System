using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_System.Dal
{
    public class Connection
    {
        SqlConnection conn = new SqlConnection();

        public Connection()
        {
            conn.ConnectionString = @"Data Source=DESKTOP-GKA8617\SQLEXPRESS;Initial Catalog=SystemLogin;Integrated Security=True";
        }

        public SqlConnection connecion()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void Desconnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
