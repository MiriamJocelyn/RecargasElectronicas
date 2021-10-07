using Contactos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Contactos.Models.Tablas;

namespace Contactos.Controllers
{
    public class SexoController : Controller
    {
        private ITablaForanea repoSexo = new SexoSql();
        // GET: Sexo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Nombre")] TablasForaneas Sexo)
        {
            repoSexo.Save(Sexo);
            return RedirectToAction("Create");
        }
    }
}