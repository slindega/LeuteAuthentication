using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthProject.Controllers
{
    public class LeuteController : Controller
    {
        // GET: Leute
        public ActionResult Index()
        {
            return View();
        }
    }
}