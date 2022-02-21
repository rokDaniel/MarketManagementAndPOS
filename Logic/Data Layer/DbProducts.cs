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
    public class DbProducts
    {
        private static MySqlConnection sqlConnection = new MySqlConnection();
        private static MySqlCommand sqlCmd = new MySqlCommand();
        private static MySqlDataReader sqlDataReader;
        private static DataTable products = new DataTable();
        private static string query;

        public static DataTable GetAllProducts()
        {
            query = "SELECT * FROM minimarket_db.products";

            products.Clear();
            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlDataReader = sqlCmd.ExecuteReader();
            products.Load(sqlDataReader);

            sqlConnection.Close();

            return products;
        }

        public static DataTable SearchProduct(string search)
        {
            query = string.Format("SELECT * FROM minimarket_db.products WHERE product_name LIKE '%{0}%' OR code LIKE '%{0}%'", search);
            products.Clear();
            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlDataReader = sqlCmd.ExecuteReader();
            products.Load(sqlDataReader);

            sqlConnection.Close();

            return products;
        }

        public static bool AddProduct(Product newProduct)
        {
            bool isSuccessful = false;

            query = string.Format(
                "INSERT INTO minimarket_db.products(code, product_name, description, category, price) " +
                "VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", newProduct.Code, newProduct.Name,
                newProduct.Description, newProduct.Category.EnumValue(), newProduct.Price.ToString());

            if(executeNonQuery())
            {
                if (DbStock.AddProduct(newProduct))
                {
                    isSuccessful = true;
                }
            }

            return isSuccessful;
        }

        private static bool executeNonQuery()
        {
            bool isSuccessful;
            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = "ALTER TABLE minimarket_db.employees AUTO_INCREMENT = 1";
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
            catch
            {
                isSuccessful = false;
            }

            return isSuccessful;
        }

        public static bool DeleteProduct(string code)
        {
            bool isSuccessful = false;

            query = string.Format("DELETE FROM minimarket_db.products WHERE code = '{0}'", code);
            if (executeNonQuery())
            {
                if (DbStock.DeleteProduct(code))
                {
                    isSuccessful = true;
                }
            }

            return isSuccessful;
        }

        public static bool UpdateProduct(Product updatedProduct)
        {
            bool isSuccessful = false;

            query = string.Format(
                "UPDATE minimarket_db.products SET product_name = '{0}', description = '{1}', " +
                "category = '{2}', price = '{3}' WHERE code = '{4}'", updatedProduct.Name,
                updatedProduct.Description, updatedProduct.Category.EnumValue(), updatedProduct.Price.ToString(), updatedProduct.Code);
            if (executeNonQuery())
            {
                if (DbStock.UpdateProduct(updatedProduct))
                {
                    isSuccessful = true;
                }
            }

            return isSuccessful;
        }

        public static string GetLastProductCode()
        {
            query = string.Format("SELECT code FROM minimarket_db.products ORDER BY code DESC LIMIT 1");
            string lastCode = string.Empty;

            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                lastCode = sqlDataReader.GetString(0);
            }

            sqlConnection.Close();

            return lastCode;
        }
    }
}
