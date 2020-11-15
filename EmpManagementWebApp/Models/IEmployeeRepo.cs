using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManagementWebApp.Models
{
    public interface IEmployeeRepo
    {
        Employee GetEmployee(int id);
    }
}
