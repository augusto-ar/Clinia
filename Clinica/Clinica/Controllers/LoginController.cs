using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinica.Model;
namespace Clinica.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult FazerLogin(LoginModel model)
        {
            return RedirectToAction("Home","Home");
        }
    }
}