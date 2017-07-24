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
using System.Web.Services;

namespace TaxesProjecte.Controllers
{
    public class HomeController : Controller
    {
        

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
                       
                        Session["id"] = obj.tc_no.ToString();
                        Session["name"] = obj.citizen_name.ToString();

                        return RedirectToAction("UserDashBoard");

                    }
                }
            }
            return View(objUser);
        }


        GV_ServisClient client = new GV_ServisClient();

        /// <summary>
        /// Bankadan 1 gelirse, servisten borclar siliniyor...
        /// </summary>
        [HttpPost]
        public ActionResult delete()
        {
            client.Delete(Session["id"].ToString());
            return RedirectToAction("http://localhost:55555/Home/UserDashBoard");
        }

        public ActionResult UserDashBoard()
        {
            if (Session["id"] != null)
            {
                string tcNo = Session["id"].ToString();

                var st = client.GetUsersDataByTcNo(tcNo);

                ViewBag.liste = st.ToList();
                return View();
            }

            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult UserDashBoard(citizen obj)
        {

            return RedirectToAction("Login");
        }

    }
}