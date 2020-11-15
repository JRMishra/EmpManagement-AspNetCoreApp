using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManagementWebApp.Models;
using EmpManagementWebApp.ViewModels;
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

        public ViewResult Index()
        {
            var model = _employeeRepo.GetAllEmployees();
            return View(model);
        }

        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepo.GetEmployee(1),
                PageTitle = "Employee Details"
            };

            return View(homeDetailsViewModel);
        }
    }
}
