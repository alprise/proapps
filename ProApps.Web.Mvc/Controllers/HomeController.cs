using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProApps.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Demos()
        {
            return View();
        }

        public ActionResult CV()
        {
            return View();
        }

        public ActionResult GermanCV()
        {
            return View();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}