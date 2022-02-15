using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Logic
{
    public class DbConnection
    {
        private static MySqlConnection conn = new MySqlConnection();
        private static MySqlCommand sqlCmd = new MySqlCommand();
        private static MySqlDataReader sqlRd;
        public static string userPrivateName { get; set; }

        public static bool IsCredetialsValid(string user, string pass)
        {
            bool isValid = false;
            
            getConnection();
            sqlCmd.Connection = conn;
            sqlCmd.CommandText = $"SELECT * FROM minimarket_db.users WHERE username='{user}' AND password='{pass}'";
            sqlRd = sqlCmd.ExecuteReader();
            if (sqlRd.Read())
            {
                userPrivateName = sqlRd.GetString("first_name");
                isValid = true;
            }

            sqlRd.Close();
            conn.Close();

            return isValid;
        }

        private static void getConnection()
        {
            string sqlConnection = "server=localhost;user id=root;password=247404Aa;database=minimarket_db";

            conn.ConnectionString = sqlConnection;
            conn.Open();
        }


    }
}
