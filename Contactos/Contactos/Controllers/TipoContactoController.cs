using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Contactos.Models.Tablas;
using Contactos.Models;

namespace Contactos.Controllers
{
    public class TipoContactoController : Controller
    {
        private ITablaForanea repoTipoC = new TipoContactoSql();

        // GET: TablaContacto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Nombre")] TablasForaneas Tipo)
        {
            repoTipoC.Save(Tipo);
            return RedirectToAction("Create");
        }
    }
}