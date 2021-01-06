using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DayTradingLog.Database
{
    class LoginDatabase : Helper
    {
        public bool ValidateLogin(string userName, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(GetRDSConnectionString()))
            {
                connection.Open();

                var sql = "select * from Users where UserID=@username and Password=@password";

                using var cmd = new MySqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Prepare();

                var result = cmd.ExecuteScalar();

                if (!(result is null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
