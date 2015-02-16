using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE_Application.Controllers
{
    public class PagesController : Controller
    {
        public ActionResult Empty()
        {
            return View();
        }

        public ActionResult Invoice()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Lockscreen()
        {
            return View();
        }
    }
}