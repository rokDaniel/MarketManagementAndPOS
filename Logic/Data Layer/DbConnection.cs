using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Logic.Data_Layer
{
    public class DbConnection
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection sqlConnection = new MySqlConnection();
            string sqlConnectionString = "server=localhost;user id=root;password=247404Aa;database=minimarket_db";

            sqlConnection.ConnectionString = sqlConnectionString;
            sqlConnection.Open();

            return sqlConnection;
        }


    }
}
