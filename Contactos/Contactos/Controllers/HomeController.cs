using Contactos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contactos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Conexion c = new Conexion();
            //c.Open();
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
    }
}