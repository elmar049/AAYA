using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Chixinti()
        {
            ViewBag.Message = "Chixinti";
            return View();
        }




        [HttpGet]
        public ActionResult Clients()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Clients(string x)
        {

            Mushteri  YeniClient = new Mushteri()
            {

            }

            var mushteradi = Request.Params["voen"];
            var musherivoeni = Request.Params["shirketadi"];
            var clientService = Request.Params["AldigiXidmet"];
            var MugavileNom = Request.Params["MugavileNom"];
            var MugavileTarix = Request.Params["Tarixi"];
            var Payment = Request.Params["Payment"];





            ViewBag.ClientName = mushteradi;
            ViewBag.Voen = musherivoeni;
            ViewBag.ClientService = clientService;
            ViewBag.MugavileNom = MugavileNom;
            ViewBag.MugavileTarix = MugavileTarix;
            ViewBag.Payment = Payment;
            return View();
        }






        public ActionResult Gelir()
        {
            ViewBag.Message = "Gelirler";
            return View();
        }

        public ActionResult Bank()
        {  
            ViewBag.Message = "Bank Rekvizitleri";
            return View();
        }
    }
}