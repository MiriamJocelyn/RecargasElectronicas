using Marbike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marbike.Controllers
{
    public class HomeController : Controller
    {
        private Helpers hp = new Helpers();
        public ActionResult Index()
        {
            List<Helpers> li = new List<Helpers>();
            li.Add(new Helpers { Id = 1, Descripcion = "Miri" });
            li.Add(new Helpers { Id = 2, Descripcion = "Max" });
            ViewBag.drpResponsable = new SelectList(li, "Id", "Descripcion");
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