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
        private readonly IEmployeeRepo _employeeRepo;

        public HomeController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public string Index()
        {
            return "Employee Name : "+ _employeeRepo.GetEmployee(1).Name;
        }

        public ViewResult Details()
        {
            Employee model = _employeeRepo.GetEmployee(1);
            ViewBag.Employee = model;
            ViewBag.PageTitle =  "Employee Details";
            return View(model);
        }
    }
}
