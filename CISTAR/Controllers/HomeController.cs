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
                if (GetGameHeader(IGBHeaders.Trusted) == "Yes")
                {

                }

                return View("IndexIGB");
            }

            return View();
        }

        private string GetGameHeader(IGBHeaders header)
        {
            var key = string.Format("HEADER_EVE_{0}", header.ToString("G"));
            var value = Request.ServerVariables.Get(key);
            return value;
        }
    }
}
