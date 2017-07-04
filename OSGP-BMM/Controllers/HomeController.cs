using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSGP_BMM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("", "Member");
        }

        //public ActionResult Message()
        //{
        //    return View();
        //}

    }
}