using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VetClinic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Auth()
        {
            ViewBag.Title = "Auth Page";
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Login Page";
            return View();
        }
        public ActionResult Pets()
        {
            ViewBag.Title = "Pets Page";
            return View();
        }
        public ActionResult NewPet()
        {
            ViewBag.Title = "New pet Page";
            return View();
        }
        public ActionResult History(string id)
        {
            ViewBag.Title = "History Page";
            return View();
        }

        public ActionResult Vaccination(string id)
        {
            ViewBag.Title = "Vaccination Page";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Title = "Services Page";
            return View();
        }
        public ActionResult NewService()
        {
            ViewBag.Title = "New Service Page";
            return View();
        }

    }
}
