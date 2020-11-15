using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManagementWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpManagementWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepo _employeeRepo;

        public HomeController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public string Index()
        {
            return "Employee Name : "+ _employeeRepo.GetEmployee(1).Name;
        }
    }
}
