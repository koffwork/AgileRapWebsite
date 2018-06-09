using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgileRapWebsite.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Index()
        {
            //Test
            return View();
        }
        public ActionResult Portfolio()
        {
            return View();
        }
        public ActionResult JoinUsNisit()
        {
            return View();
        }
        public ActionResult JoinUsEmployee()
        {
            return View();
        }
        public ActionResult OurService()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }

    }
}