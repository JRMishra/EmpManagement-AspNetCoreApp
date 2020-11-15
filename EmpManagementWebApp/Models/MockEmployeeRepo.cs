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
                new Employee(){Id = 1, Name = "Supratim", Department = "Finance", Email = "supratim@mymail.com"},
                new Employee(){Id = 2, Name = "Sayan", Department = "Operation", Email = "sayan@mymail.com"},
                new Employee(){Id = 3, Name = "Debabrata", Department = "Marketing", Email = "debabrata@mymail.com"}
            };
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(emp => emp.Id == id);
        }
    }
}
