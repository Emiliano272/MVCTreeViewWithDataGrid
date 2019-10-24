using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TreeViewDataGrid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Employee> list = new List<Employee>();
            using (MyDBEntities dc = new MyDBEntities())
            {
                list = dc.Employees.OrderBy(a => a.EmployeeID).ToList();
            }
            return View(list);
        }
    }
}