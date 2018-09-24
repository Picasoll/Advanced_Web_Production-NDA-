using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;
using Newtonsoft.Json;
using System.Web.Security;
using System.Data;
using ASPSnippets.TwitterAPI;
using CallOut.Models;


namespace CallOut.Controllers
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

        //[HttpPost]
        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }

        public ActionResult ShareProblems()
        {
            ViewBag.Message = "Your Share Problems page.";
            return View();
        }

        public ActionResult SharePage()
        {
            ViewBag.Message = "Your Share page.";
            return View();
        }
    }
}