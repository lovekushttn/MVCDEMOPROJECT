using MVCDEMO.Web.Models.Interface;
using MVCDEMO.Web.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDEMO.Web.Controllers
{
    public class EmployeeController : Controller
    {
        readonly IEmployeeService employeeService;
        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }
        // GET: Employee
        public ActionResult Detail(int? empId)
        {
            if (empId.HasValue)
            {
                var emp = employeeService.GetEmployee(empId.Value);
                return View(emp);
            }
            else
            {
                return this.Content("Employee not found");
            }
            //var empId = Convert.ToInt32(Request.Form["empId"]);
            
        }
        public ActionResult GetEmployees()
        {
            var result = employeeService.GetEmployees();
            return View("Index", result);
        }
    }
}