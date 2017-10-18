using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.TraceInformation("Index page request");
            Trace.WriteLine("Just a general verbose trace message");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            Trace.TraceInformation("About page request");
            Trace.TraceWarning("Warning on the about page");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Trace.TraceInformation("Contact page request");
            Trace.TraceError("Error on the contact page");
            return View();
        }
    }
}