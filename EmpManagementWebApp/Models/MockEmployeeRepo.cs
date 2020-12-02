using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManagementWebApp.Models
{
    public class MockEmployeeRepo : IEmployeeRepo
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepo()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Supratim", Department = Dept.Finance, Email = "supratim@mymail.com"},
                new Employee(){Id = 2, Name = "Sayan", Department = Dept.Operation, Email = "sayan@mymail.com"},
                new Employee(){Id = 3, Name = "Debabrata", Department = Dept.Marketing, Email = "debabrata@mymail.com"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id  = _employeeList.Max(employee => employee.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(emp => emp.Id == id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(employee => employee.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employee.Name;
                employee.Email = employee.Email;
                employee.Department = employee.Department;
            }
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(employee => employee.Id == id);
            if (employee != null)
                _employeeList.Remove(employee);
            return employee;
        }
    }
}
