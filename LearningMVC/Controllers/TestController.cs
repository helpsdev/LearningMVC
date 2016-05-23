using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMVC.Controllers
{
    public class TestController : Controller
    {
        public String GetMessage()
        {
            return "Hello world is old now. It's time for wassup bro ;)";
        }

        public ActionResult GetView()
        {
            Models.Employee emp1 = new Models.Employee();
            emp1.FirstName = "Kinnereth";
            emp1.LastName = "Beltran";
            emp1.Salary = 2000;
            //ViewData["Employee"] = emp1;
            ViewBag.Employee = emp1;
            return View("MyView");
        }
    }
}