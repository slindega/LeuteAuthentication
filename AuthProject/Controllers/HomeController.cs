using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace AuthProject.Controllers
{
    [Authorize]
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
        public ActionResult Jobs()
        {
            ViewBag.Message = "Så er der ledige stillinger";
            return View();
        }
        
        public ActionResult Personlig()
        {
            ViewBag.Message = "Oversigt over dokumenter for ";
            ViewBag.Name = User.Identity.GetUserName();
            ViewBag.mm = "Og det kan selfølgelig laves pænere";
            return View();
        }
    }
}