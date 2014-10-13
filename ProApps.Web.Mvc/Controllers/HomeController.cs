using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProApps.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Demos(int? totalItems = 8)
        {
            if (totalItems.HasValue && totalItems.Value > 100)
            {
                totalItems = 100;
            }
            var model = Enumerable.Range(1, totalItems.Value);

            return View(model);
        }

        public ActionResult CV()
        {
            return View();
        }

        public ActionResult GermanCV()
        {
            return View();
        }

        public ActionResult GermanCL()
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