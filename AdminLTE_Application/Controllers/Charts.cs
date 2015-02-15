using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE_Application.Controllers
{
    public class ChartsController : Controller
    {
        public ActionResult Flot()
        {
            return View();
        }

        public ActionResult Inline()
        {
            return View();
        }

        public ActionResult Morris()
        {
            return View();
        }
    }
}