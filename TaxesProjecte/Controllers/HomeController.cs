using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TaxesProjecte.Migrations;
using TaxesProjecte.Controllers;
using TaxesProjecte.Models;
using TaxesProjecte.Data_Access;
using TaxesProjecte.GovernmentService;



namespace TaxesProjecte.Controllers
{
    public class HomeController : Controller
    {
        GV_ServisClient client = new GV_ServisClient();



        // GET: Home
        /// <summary>
        /// 3d secure how to work js
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(citizen objUser)
        {
            
            if (ModelState.IsValid)
            {
                using (Context db = new Context())
                {
                    var obj = db.citizens_tbl.Where(a => a.tc_no.Equals(objUser.tc_no) && a.password.Equals(objUser.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        //burada devlet serverine tc no ile bir sorgulama yapilacak, 
                        //geri gelen list halinde olan veriler session ile dashboard sayfasina gonderilecek
                        Session["id"] = obj.tc_no.ToString();
                        Session["name"] = obj.citizen_name.ToString();



                        return RedirectToAction("UserDashBoard");

                    }
                }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["id"] != null)
            {
                string tcNo = Session["id"].ToString();

                var st = client.GetUsersDataByTcNo(tcNo);
                
                foreach(var itm in st)
                {
                    
                }

                ViewBag.liste = st.ToList();
                
                
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }


        [HttpGet]
        public ActionResult PaymentToBank()
        {

            string tcNo = Session["id"].ToString();
            decimal i = 0m;

            var st = client.GetUsersDataByTcNo(tcNo);
            foreach (var itm in st)
            {
                i += itm.amount;
            }
            ViewData["denene"] = i;
           
            return View();
        }
    }
}