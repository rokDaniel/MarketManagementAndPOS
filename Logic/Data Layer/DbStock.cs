using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Data_Layer
{
    public class DbStock
    {
        private static MySqlConnection sqlConnection = new MySqlConnection();
        private static MySqlCommand sqlCmd = new MySqlCommand();
        private static MySqlDataReader sqlDataReader;
        private static DataTable stock = new DataTable();
        private static string query;

        public static DataTable GetStock()
        {
            query = "SELECT * FROM minimarket_db.stock";

            stock.Clear();
            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlDataReader = sqlCmd.ExecuteReader();
            stock.Load(sqlDataReader);

            sqlConnection.Close();

            return stock;
        }

        public static object SearchProduct(string search)
        {
            query = string.Format("SELECT * FROM minimarket_db.stock WHERE product_name LIKE '%{0}%' OR code LIKE '%{0}%'", search);
            stock.Clear();
            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlDataReader = sqlCmd.ExecuteReader();
            stock.Load(sqlDataReader);

            sqlConnection.Close();

            return stock;
        }
    }
}
