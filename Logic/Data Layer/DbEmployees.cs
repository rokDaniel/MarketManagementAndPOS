using Logic.Business_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Data_Layer
{
    public class DbEmployees
    {
        private static MySqlConnection sqlConnection = new MySqlConnection();
        private static MySqlCommand sqlCmd = new MySqlCommand();
        private static MySqlDataReader sqlDataReader;
        private static DataTable employees = new DataTable();
        private static string query;
        public enum eSearchType
        {
            Name,
            Role
        }

        public static DataTable GetAllEmployees()
        {
            query = "SELECT * FROM minimarket_db.employees";

            employees.Clear();
            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlDataReader = sqlCmd.ExecuteReader();
            employees.Load(sqlDataReader);
            sqlConnection.Close();

            return employees;
        }

        public static DataTable SearchEmployee(string search, eSearchType searchType)
        {
            getSearchQuery(search, searchType);
            employees.Clear();
            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlDataReader = sqlCmd.ExecuteReader();
            employees.Load(sqlDataReader);
            sqlConnection.Close();

            return employees;
        }

        private static void getSearchQuery(string search, eSearchType searchType)
        {
            if (searchType == eSearchType.Name)
            {
                query = string.Format("SELECT * FROM minimarket_db.employees WHERE full_name LIKE '%{0}%'", search);
            }
            else
            {
                if (string.Equals(search, "All"))
                {
                    query = string.Format("SELECT * FROM minimarket_db.employees");
                }
                else
                {
                    query = string.Format("SELECT * FROM minimarket_db.employees WHERE role = '{0}'", search);
                }
            }
        }

        public static string GetEmployeeName(string username)
        {
            query = string.Format("SELECT full_name FROM minimarket_db.employees WHERE username = '{0}'", username);
            string userPrivateName;

            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlDataReader = sqlCmd.ExecuteReader();
            sqlDataReader.Read();
            userPrivateName = sqlDataReader.GetString(0);
            sqlConnection.Close();

            return userPrivateName;
        }

        public static bool AddEmployee(Employee newEmployee)
        {
            bool isSuccessful;
            query = string.Format(
                "INSERT INTO minimarket_db.employees(full_name, address, contact_number, role, username, status) " +
                "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", newEmployee.FulllName, newEmployee.Address,
                newEmployee.ContactNo, newEmployee.EmployeeRole.ToString(), newEmployee.UserName, newEmployee.EmployeeStatus.ToString());

            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = "ALTER TABLE minimarket_db.employees AUTO_INCREMENT = 1";
            sqlCmd.ExecuteNonQuery();
            sqlCmd.CommandText = query;

            try
            {
                sqlCmd.ExecuteNonQuery();
                isSuccessful = true;
            }
            catch (Exception)
            {
                isSuccessful = false;
            }

            sqlConnection.Close();

            return isSuccessful;
        }

        public static bool DeleteEmployee(int id)
        {
            bool isSuccessful;
            query = string.Format("DELETE FROM minimarket_db.employees WHERE id = {0}", id);
            string userPrivateName;

            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;

            try
            {
                sqlCmd.ExecuteNonQuery();
                isSuccessful = true;
            }
            catch (Exception)
            {
                isSuccessful = false;
            }

            sqlConnection.Close();

            return isSuccessful;
        }
    }
}
