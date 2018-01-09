//using PerpetuumSoft.Knockout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace knockouttest.Controllers
{
    public class HomeController : Controller//KnockoutController
    {
        public ActionResult Index()
        {

            ViewBag.Message = "foreach binding test.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "test deneme";
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult textbinding()
        {
            ViewBag.Message = "text binding test.";

            return View();
        }

        public ActionResult cssbinding()
        {
            ViewBag.Message = "css binding test.";

            return View();
        }


        public ActionResult optionbinding()
        {
            ViewBag.Message = "option binding test.";

            return View();
        }

        public ActionResult templatetest()
        {
            ViewBag.Message = "template test.";

            return View();
        }

        public ActionResult AcilirListe()
        {
            return View();
        }

    }
}