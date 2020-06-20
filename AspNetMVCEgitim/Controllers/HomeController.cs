using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCEgitim.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UrunEkle()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UrunListele()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}