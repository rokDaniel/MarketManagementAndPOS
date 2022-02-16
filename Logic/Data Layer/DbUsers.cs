using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Data_Layer
{
    public class DbUsers
    {
        private static MySqlConnection sqlConnection = new MySqlConnection();
        private static MySqlCommand sqlCmd = new MySqlCommand();
        private static MySqlDataReader sqlDataReader;
        private static string query;

        public static bool IsCredetialsValid(string user, string pass)
        {
            bool isValid = false;

            query = string.Format("SELECT * FROM minimarket_db.users WHERE username='{0}' AND password='{1}'", user, pass);
            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                isValid = true;
            }

            sqlDataReader.Close();
            sqlConnection.Close();

            return isValid;
        }
    }
}
