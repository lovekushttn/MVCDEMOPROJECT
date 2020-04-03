using MVCDEMO.Web.Models.Entity;
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
        [AcceptVerbs(HttpVerbs.Put | HttpVerbs.Post | HttpVerbs.Put)]
        public ActionResult Detail(int? empId)
        {
            if (empId.HasValue)
            {
                var emp = employeeService.GetEmployee(empId.Value);
                return View(emp);
            }
            else
            {
                return RedirectToAction("Index", "Home");
                //return this.Content("Employee not found");
            }
            //var empId = Convert.ToInt32(Request.Form["empId"]);
            
        }
       // [Route("emps",Name ="Default3")]
       // [ActionName("list")]
        public ActionResult GetEmployees()
        {
            var result = GetEmployeeList();
            return View("Index", result);
        }
        [NonAction]
        public IEnumerable<Employee> GetEmployeeList()
        {
            var result = employeeService.GetEmployees();
            return result;
        }
       
    }
}