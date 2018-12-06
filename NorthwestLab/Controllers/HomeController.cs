using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwestLab.DAL;
using NorthwestLab.Models;
using System.Net;
using System.Data.Entity;

namespace NorthwestLab.Controllers
{
    public class HomeController : Controller
     
    {
        NorthwestLabContext db = new NorthwestLabContext();

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

        public ActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Login(FormCollection, rememberMe)
        //{
        //    return View("Index", "ClientPortal");
        //}
    }
}