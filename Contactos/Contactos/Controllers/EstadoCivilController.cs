using Contactos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Contactos.Models.Tablas;

namespace Contactos.Controllers
{
    public class EstadoCivilController : Controller
    {
        private ITablaForanea repoEstadoC = new EstadoCivilSql();
        // GET: EstadoCivil
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Nombre")] TablasForaneas EstadoCivil)
        {
            repoEstadoC.Save(EstadoCivil);
            return RedirectToAction("Create");
        }
    }
}