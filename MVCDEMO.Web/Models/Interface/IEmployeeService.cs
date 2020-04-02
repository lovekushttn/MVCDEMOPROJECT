using MVCDEMO.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDEMO.Web.Models.Interface
{
    public interface IEmployeeService
    {
         IEnumerable<Employee> GetEmployees();
         Employee GetEmployee(int id);
    }
}