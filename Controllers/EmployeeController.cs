using Sample_Project_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_Project_EF.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        private readonly DemoEmployeeEntities _dbContext = new DemoEmployeeEntities();

        public ActionResult Index()
        {
            var employee = _dbContext.Employees.ToList();
            return View(employee);
        }
    }
}