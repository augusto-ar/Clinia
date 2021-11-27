using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View("Index");
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}