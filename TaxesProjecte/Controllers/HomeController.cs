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

namespace TaxesProjecte.Controllers
{
    public class HomeController : Controller
    {
        //WebServisClient client = new WebServisClient();

        // GET: Home
        public ActionResult Login()
        {
            //string isim = "Ammmamamamar";
            //ViewBag.msj = client.BirTaneHelloWorldGonderBanaBakayim(isim);
            //ViewBag.hesapla = client.hesapla(3, 2);


            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(citizen objUser)
        {

            //GvServiceReference.GV_ServisClient clientService = new GvServiceReference.GV_ServisClient();
            //GvServiceReference.Users user = clientService.GetDogsWithBreedNames("99559453436");



            if (ModelState.IsValid)
            {
                using (Context db = new Context())
                {
                    var obj = db.citizens_tbl.Where(a => a.email.Equals(objUser.email) && a.password.Equals(objUser.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        //burada devlet serverine tc no ile bir sorgulama yapilacak, 
                        //geri gelen list halinde olan veriler session ile dashboard sayfasina gonderilecek
                        Session["id"] = obj.tc_no.ToString();
                        Session["email"] = obj.citizen_name.ToString();



                        return RedirectToAction("UserDashBoard");

                    }
                }
            }
            return View(objUser);
        }

        public void MyAction()
        {

        }
        public ActionResult UserDashBoard()
        {



            if (Session["id"] != null)
            {
                string tcNo = Session["id"].ToString();

                ViewBag.email1 = Session["id"].ToString();

                //string list ile getirme
                //ViewBag.email = client.emailGetir(tcNo);

                //var hello = client.emailGetir(tcNo);

                //ViewData["MyData"] = hello;


                List<citizen> begle = new List<citizen>();

                //string[] veriler = client.emailGetir(tcNo);


                //ViewBag.email3 = veriler[0];


                //Dictionary ile getirme 
                Dictionary<string, string> bunlar =
                                                new Dictionary<string, string>();
                //bunlar = client.emailGetir2(tcNo);
                //string isim = bunlar["ismi"];
                //string emaili = bunlar["emaili"];

                //ViewBag.ismi = isim;
                //ViewBag.emaili = emaili;

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}