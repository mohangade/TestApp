using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAzureFWProj.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            System.Diagnostics.Trace.TraceInformation("Invoking the contoller.");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}