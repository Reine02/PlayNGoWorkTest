using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OSGP_BMM.Models.DB;

namespace OSGP_BMM.Controllers
{
    public class MemberController : Controller
    {
        private MadelieneDBEntities db = new MadelieneDBEntities();

        // GET: /Member/
        public ActionResult Index()
        {
            ViewBag.Members = db.dbo_Members.ToList();
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
