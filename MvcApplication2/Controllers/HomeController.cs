using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "MVC Application to test TeamCity CI Automation.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This MVC page is targeting .NET Framework 4.0.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Created by Anthony Baker. Check my blog: http://blog.anthonybaker.me";

            return View();
        }
    }
}
