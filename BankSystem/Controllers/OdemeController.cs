using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BankSystem.Controllers
{
    public class OdemeController : Controller
    {

        // GET: Odeme
        public ActionResult Index()
        {
            //int a = (int)TempData["asd"];
            return View();
        }

        [HttpPost]
        public ActionResult Index(Boolean a)
        {

            return RedirectToAction("getir");
        }


        public ActionResult getir()
        {
            return View();
        }

        public ActionResult PaymentToBank()
        {
            //TempData["asd"] = 3;
            //var request = Request.Form;

            return View() ;

        }
    }
}