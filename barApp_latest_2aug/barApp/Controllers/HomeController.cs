using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace barApp.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Dine()
        {

            return View();
            // reservation confirmed
        }

        public ActionResult Pickup()
        {
            return View();

        }

        public ActionResult Delivery()
        {
            return View();

        }

        public ActionResult Login()
        {

            return View();
        }

        public ActionResult Reservation()
        {

            return View();
        }

        public ActionResult Story()
        {
            return View();

        }

        public ActionResult Confirmed()
        {
            return View();

        }
    }
}