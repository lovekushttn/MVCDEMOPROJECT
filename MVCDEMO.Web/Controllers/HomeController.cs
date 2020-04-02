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
    public class HomeController:Controller
    {
        readonly IEmployeeService employeeService;
        public HomeController()
        {
            employeeService = new EmployeeService();
        }
        public ActionResult Index()
        {
            var result = employeeService.GetEmployees();
            return View("Home");
        }
        

    }
}