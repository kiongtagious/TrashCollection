using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace TrashCollection.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //[Authorize]
        public ActionResult EmployeeLogin()
        {
            ViewBag.Message = "Customers On My Route";

            return View();

        }
        public ActionResult EmployeeProfile()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //[Authorize]
        public ActionResult CustomerLogin()
        {
            //ViewBag.Message = "Let's get started!";

            return View();
        }
    }
}