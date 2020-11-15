using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmpManagementWebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from MVC Home -> Controller -> Index Action";
        }
    }
}
