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
    public class PrendasController : Controller
    {
        private ElHilvanEntities db = new ElHilvanEntities();

        // GET: Prendas
        public ActionResult Index()
        {
            var prenda = db.Prenda.Include(p => p.TipoArreglo).Include(p => p.TipoPrenda);
            return View(prenda.ToList());
        }

        // GET: Prendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prenda prenda = db.Prenda.Find(id);
            if (prenda == null)
            {
                return HttpNotFound();
            }
            return View(prenda);
        }

        // GET: Prendas/Create
        public ActionResult Create()
        {
            ViewBag.idTipoArreglo = new SelectList(db.TipoArreglo, "id", "Nombre");
            ViewBag.idTipoPrenda = new SelectList(db.TipoPrenda, "id", "Nombre");
            return View();
        }

        // POST: Prendas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idTipoPrenda,idTipoArreglo,Descripcion")] Prenda prenda)
        {
            if (ModelState.IsValid)
            {
                db.Prenda.Add(prenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idTipoArreglo = new SelectList(db.TipoArreglo, "id", "Nombre", prenda.idTipoArreglo);
            ViewBag.idTipoPrenda = new SelectList(db.TipoPrenda, "id", "Nombre", prenda.idTipoPrenda);
            return View(prenda);
        }

        // GET: Prendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prenda prenda = db.Prenda.Find(id);
            if (prenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.idTipoArreglo = new SelectList(db.TipoArreglo, "id", "Nombre", prenda.idTipoArreglo);
            ViewBag.idTipoPrenda = new SelectList(db.TipoPrenda, "id", "Nombre", prenda.idTipoPrenda);
            return View(prenda);
        }

        // POST: Prendas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idTipoPrenda,idTipoArreglo,Descripcion")] Prenda prenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idTipoArreglo = new SelectList(db.TipoArreglo, "id", "Nombre", prenda.idTipoArreglo);
            ViewBag.idTipoPrenda = new SelectList(db.TipoPrenda, "id", "Nombre", prenda.idTipoPrenda);
            return View(prenda);
        }

        // GET: Prendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prenda prenda = db.Prenda.Find(id);
            if (prenda == null)
            {
                return HttpNotFound();
            }
            return View(prenda);
        }

        // POST: Prendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prenda prenda = db.Prenda.Find(id);
            db.Prenda.Remove(prenda);
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
