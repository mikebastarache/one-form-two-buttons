using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        //
        // POST: /Home
        [HttpPost]
        public ActionResult Index(FormCollection oCollection)
        {
            ViewBag.Message = "Post back happend";

            foreach (var key in oCollection.AllKeys)
            {
                var value = oCollection[key];
                Response.Write(value + "<br>");
            }

            foreach (var key in oCollection.Keys)
            {
                var value = oCollection[key.ToString()];
                Response.Write(value + "<br>");
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
