using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Business_Layer
{
    public class Employee
    {
        public enum eEmployeeRole
        {
            Administrator,
            Cashier,
            WarehouseClerk
        }

        public enum eEmployeeStatus
        {
            Active,
            Vacation,
            Sick
        }

        public int Id { get; set; }
        public string FulllName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string UserName { get; set; }
        public eEmployeeRole EmployeeRole { get; set; }
        public eEmployeeStatus EmployeeStatus { get; set; }

        public Employee(string fullName, string address, string contactNo, string userName, int employeeRoleIndex, int employeeStatusIndex)
        {
            FulllName = fullName;
            Address = address;
            ContactNo = contactNo;
            UserName = userName;
            EmployeeRole = (eEmployeeRole)employeeRoleIndex;
            EmployeeStatus = (eEmployeeStatus)employeeStatusIndex;
        }

        public Employee(int id, string fullName, string address, string contactNo, string userName, int employeeRoleIndex, int employeeStatusIndex)
        {
            Id = id;
            FulllName = fullName;
            Address = address;
            ContactNo = contactNo;
            UserName = userName;
            EmployeeRole = (eEmployeeRole)employeeRoleIndex;
            EmployeeStatus = (eEmployeeStatus)employeeStatusIndex;
        }
    }
}
