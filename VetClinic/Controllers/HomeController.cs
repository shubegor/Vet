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
        public ActionResult AllPets()
        {
            ViewBag.Title = "Pets Page";
            return View();
        }
        public ActionResult AllUsers()
        {
            ViewBag.Title = "Users Page";
            return View();
        }
        public ActionResult AllServices()
        {
            ViewBag.Title = "Services Page";
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
        public ActionResult NewServiceAdmin()
        {
            ViewBag.Title = "New Service Page";
            return View();
        }
        public ActionResult EditPet()
        {
            ViewBag.Title = "Edit pet Page";
            return View();
        }
        public ActionResult EditUser()
        {
            ViewBag.Title = "Edit user Page";
            return View();
        }
        public ActionResult UserServices()
        {
            ViewBag.Title = "User service Page";
            return View();
        }
        public ActionResult EditService()
        {
            ViewBag.Title = "Edit service Page";
            return View();
        }
        public ActionResult DeleteService()
        {
            ViewBag.Title = "Delete service Page";
            return View();
        }
    }
}
