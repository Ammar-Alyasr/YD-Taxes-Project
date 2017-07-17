using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Text;
using System.Net;
using System.Collections.Specialized;

namespace BankSystem.Controllers
{
    public class OdemeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        // GET: Odeme
        public ActionResult Index()
        {

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

            var request = Request.Form;
            return View();
        }
    }
}