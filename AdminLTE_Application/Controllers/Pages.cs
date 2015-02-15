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
    }
}