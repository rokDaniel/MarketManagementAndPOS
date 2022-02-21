using Logic.Business_Layer;
using Logic.Extension;
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

        public static DataTable SearchProduct(string search)
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

        public static void updateQuantity(string productCode, int quantityToAdd)
        {
            query = string.Format("UPDATE minimarket_db.stock SET quantity = quantity + {0} WHERE code = '{1}'", quantityToAdd, productCode);
            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlCmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static bool AddProduct(Product newProduct)
        {
            bool isSuccessful = false;

            query = string.Format(
                "INSERT INTO minimarket_db.stock(code, product_name, description, quantity) " +
                "VALUES('{0}', '{1}', '{2}', '{3}')", newProduct.Code, newProduct.Name,
                newProduct.Description, newProduct.Quantity);

            if (executeNonQuery())
            {
                isSuccessful = true;

            }

            return isSuccessful;
        }

        private static bool executeNonQuery()
        {
            bool isSuccessful;
            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = "ALTER TABLE minimarket_db.stock AUTO_INCREMENT = 1";
            sqlCmd.ExecuteNonQuery();
            sqlCmd.CommandText = query;
            isSuccessful = tryExecuting();
            sqlConnection.Close();

            return isSuccessful;
        }

        private static bool tryExecuting()
        {
            bool isSuccessful;

            try
            {
                sqlCmd.ExecuteNonQuery();
                isSuccessful = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                isSuccessful = false;
            }

            return isSuccessful;
        }

        internal static bool DeleteProduct(string code)
        {
            bool isSuccessful;

            query = string.Format("DELETE FROM minimarket_db.stock WHERE code = '{0}'", code);
            isSuccessful = executeNonQuery();

            return isSuccessful;
        }

        internal static bool UpdateProduct(Product updatedProduct)
        {
            bool isSuccessful = false;

            query = string.Format(
                "UPDATE minimarket_db.stock SET product_name = '{0}', description = '{1}' WHERE code = '{2}'",
                updatedProduct.Name, updatedProduct.Description, updatedProduct.Code);
            isSuccessful = executeNonQuery();

            return isSuccessful;
        }
    }
}
