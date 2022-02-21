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
            Role,
            Id
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
            switch(searchType)
            {
                case eSearchType.Name:
                    query = string.Format("SELECT * FROM minimarket_db.employees WHERE full_name LIKE '%{0}%'", search);
                    break;
                case eSearchType.Role:
                    if (string.Equals(search, "All"))
                    {
                        query = string.Format("SELECT * FROM minimarket_db.employees");
                    }
                    else
                    {
                        query = string.Format("SELECT * FROM minimarket_db.employees WHERE role = '{0}'", search);
                    }

                    break;
            }
        }

        public static string GetEmployeeName(string username)
        {
            query = string.Format("SELECT full_name FROM minimarket_db.employees WHERE username = '{0}'", username);
            string userPrivateName = string.Empty;

            sqlConnection = DbConnection.GetConnection();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = query;
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                userPrivateName = sqlDataReader.GetString(0);
            }
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

            isSuccessful = executeNonQuery();

            return isSuccessful;
        }

        public static bool UpdateEmployee(Employee updatedEmployee)
        {
            bool isSuccessful;
            query = string.Format(
                "UPDATE minimarket_db.employees SET full_name = '{0}', address = '{1}', contact_number = '{2}', " +
                "role = '{3}', username = '{4}', status = '{5}' WHERE id = '{6}'", updatedEmployee.FulllName, updatedEmployee.Address,
                updatedEmployee.ContactNo, updatedEmployee.EmployeeRole.ToString(), updatedEmployee.UserName, updatedEmployee.EmployeeStatus.ToString(), updatedEmployee.Id);

            isSuccessful = executeNonQuery();

            return isSuccessful;
        }

        public static bool DeleteEmployee(int id)
        {
            bool isSuccessful;

            query = string.Format("DELETE FROM minimarket_db.employees WHERE id = {0}", id);
            isSuccessful = executeNonQuery();

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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                isSuccessful = false;
            }

            return isSuccessful;
        }
    }
}
