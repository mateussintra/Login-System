using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_System.Dal
{
    public class LoginDalCommand
    {
        public bool have = false;
        public string message = "";
        SqlCommand cmd = new SqlCommand();
        Connection conn = new Connection();
        SqlDataReader dr;

        public bool veriLogin(string login, string password)
        {
            cmd.CommandText = "SELECT * FROM logins WHERE loginname = @login and password = @password";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            try
            {
                cmd.Connection = conn.connecion();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    have = true;
                }
                conn.Desconnection();
                dr.Close();
            }
            catch (SqlException)
            {

                this.message = "Error connecting to database!!!";
            }
            return have;
        }

        public string register(string name, string email, string login, string password, string confPassword)
        {
            have = false;
            if (password.Equals(confPassword))
            {
                cmd.CommandText = "INSERT INTO logins VALUES (@NAME,@EMAIL,@LOGINNAME,@PASSWORD)";
                cmd.Parameters.AddWithValue("@NAME", name);
                cmd.Parameters.AddWithValue("@EMAIL", email);
                cmd.Parameters.AddWithValue("@LOGINNAME", login);
                cmd.Parameters.AddWithValue("@PASSWORD", password);

                try
                {
                    cmd.Connection = conn.connecion();
                    cmd.ExecuteNonQuery();
                    conn.Desconnection();
                    this.message = "Register successfully";
                    have = true;
                }
                catch (SqlException)
                {

                    this.message = "Error connecting to database!!!";
                }
            }
            else
            {
                this.message = "passwords are not the same";
            }
            return message;
        }
    }
}
