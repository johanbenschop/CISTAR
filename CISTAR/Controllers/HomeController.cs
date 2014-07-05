using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CISTAR.Models;

namespace CISTAR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // In case the client is the IGB then return the specific IGB View.
            if (Request.UserAgent != null && Request.UserAgent.EndsWith("EVE-IGB"))
            {
                return View("IndexIGB");
            }

            return View();
        }

    }
}
