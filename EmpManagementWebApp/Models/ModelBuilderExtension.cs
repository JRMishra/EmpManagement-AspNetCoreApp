using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManagementWebApp.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Jyoti Ranjan",
                    Department = Dept.IT,
                    Email = "jrm@mymail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Supratim Dey",
                    Department = Dept.Marketing,
                    Email = "supdey@mymail.com"
                },
                new Employee
                {
                    Id = 3,
                    Name = "Sayan Dash",
                    Department = Dept.Operation,
                    Email = "sayan@mymail.com"
                }
            );
        }
    }
}
