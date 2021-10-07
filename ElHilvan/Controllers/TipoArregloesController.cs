using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TipoArregloesController : Controller
    {
        private ElHilvanEntities db = new ElHilvanEntities();

        // GET: TipoArregloes
        public ActionResult Index()
        {
            return View(db.TipoArreglo.ToList());
        }

        // GET: TipoArregloes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoArreglo tipoArreglo = db.TipoArreglo.Find(id);
            if (tipoArreglo == null)
            {
                return HttpNotFound();
            }
            return View(tipoArreglo);
        }

        // GET: TipoArregloes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoArregloes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Nombre,idPrecio")] TipoArreglo tipoArreglo)
        {
            if (ModelState.IsValid)
            {
                db.TipoArreglo.Add(tipoArreglo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoArreglo);
        }

        // GET: TipoArregloes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoArreglo tipoArreglo = db.TipoArreglo.Find(id);
            if (tipoArreglo == null)
            {
                return HttpNotFound();
            }
            return View(tipoArreglo);
        }

        // POST: TipoArregloes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Nombre,idPrecio")] TipoArreglo tipoArreglo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoArreglo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoArreglo);
        }

        // GET: TipoArregloes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoArreglo tipoArreglo = db.TipoArreglo.Find(id);
            if (tipoArreglo == null)
            {
                return HttpNotFound();
            }
            return View(tipoArreglo);
        }

        // POST: TipoArregloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoArreglo tipoArreglo = db.TipoArreglo.Find(id);
            db.TipoArreglo.Remove(tipoArreglo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
