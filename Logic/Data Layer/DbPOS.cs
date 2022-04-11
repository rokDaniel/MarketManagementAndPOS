using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Data_Layer
{
    public class DbPOS
    {
        private static MySqlConnection sqlConnection = new MySqlConnection();
        private static MySqlCommand sqlCmd = new MySqlCommand();
        private static MySqlDataReader sqlDataReader;
        private static DataTable products = new DataTable();
        private static string query;

        public static DataTable GetAllProducts()
        {
            query = "SELECT p.number, code, p.product_name, category, price, p.description, quantity FROM" +
                " minimarket_db.products as p INNER JOIN minimarket_db.stock as s using(code)";

            products.Clear();
            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlDataReader = sqlCmd.ExecuteReader();
            products.Load(sqlDataReader);

            sqlConnection.Close();

            return products;
        }
    }
}
