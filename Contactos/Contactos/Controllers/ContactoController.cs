using Contactos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Contactos.Models.Tablas;


namespace Contactos.Controllers
{
    public class ContactoController : Controller
    {
        //private string connectionString= @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\dbExamen.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";
        private IContactoIn repoContacto = new ContactosSql();
        private ITablaForanea repoTipoC = new TipoContactoSql();
        private ITablaForanea repoSexo = new SexoSql();
        private ITablaForanea repoEstadoCivil = new EstadoCivilSql();
        // GET: Contacto
        public ActionResult Index()
        {

            return View(repoContacto.GetAll());
        }

        public ActionResult Create()
        {
            
            List<TablasForaneas> TiposContactos = new List<TablasForaneas>();
            TiposContactos = repoTipoC.GetAll();
            ViewBag.IdTipoContacto = new SelectList(repoTipoC.GetAll(), "Id", "Nombre");
            ViewBag.IdSexo = new SelectList(repoSexo.GetAll(), "Id", "Nombre");
            ViewBag.IdEstadoCivil = new SelectList(repoEstadoCivil.GetAll(), "Id", "Nombre");
           
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Nombre,IdTipoContacto,TelefonoFijo,TelefonoMovil,FechaNacimiento,IdSexo,IdEstadoCivil")] Contacto contacto)
        {
            repoContacto.Save(contacto);
            return RedirectToAction("Create");
        }
        public ActionResult Edit(int id)
        {
            Contacto cEdit = new Contacto();
            cEdit = repoContacto.Busquedas(id);

            if (cEdit == null)
            {
                return HttpNotFound();
            }

            ViewBag.IdTipoContacto = new SelectList(repoTipoC.GetAll(), "Id", "Nombre",cEdit.IdTipoContacto);
            ViewBag.IdSexo = new SelectList(repoSexo.GetAll(), "Id", "Nombre",cEdit.IdSexo);
            ViewBag.IdEstadoCivil = new SelectList(repoEstadoCivil.GetAll(), "Id", "Nombre",cEdit.IdEstadoCivil);
            return View(cEdit);
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Nombre,IdTipoContacto,TelefonoFijo,TelefonoMovil,FechaNacimiento,IdSexo,IdEstadoCivil")] Contacto contacto)
        {
            repoContacto.Edit(contacto);
            ViewBag.IdTipoContacto = new SelectList(repoTipoC.GetAll(), "Id", "Nombre", contacto.IdTipoContacto);
            ViewBag.IdSexo = new SelectList(repoSexo.GetAll(), "Id", "Nombre", contacto.IdSexo);
            ViewBag.IdEstadoCivil = new SelectList(repoEstadoCivil.GetAll(), "Id", "Nombre", contacto.IdEstadoCivil);

            return View();

        }

    }
}