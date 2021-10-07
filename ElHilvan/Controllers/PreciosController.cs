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
    public class PreciosController : Controller
    {
        private ElHilvanEntities db = new ElHilvanEntities();

        // GET: Precios
        public ActionResult Index()
        {
            var precio = db.Precio.Include(p => p.TipoArreglo).Include(p => p.TipoPrenda);
            return View(precio.ToList());
        }

        // GET: Precios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Precio precio = db.Precio.Find(id);
            if (precio == null)
            {
                return HttpNotFound();
            }
            return View(precio);
        }

        // GET: Precios/Create
        public ActionResult Create()
        {
            ViewBag.idArreglo = new SelectList(db.TipoArreglo, "id", "Nombre");
            ViewBag.idTipoPrenda = new SelectList(db.TipoPrenda, "id", "Nombre");
            return View();
        }

        // POST: Precios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idTipoPrenda,idArreglo,Cantidad")] Precio precio)
        {
            if (ModelState.IsValid)
            {
                db.Precio.Add(precio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idArreglo = new SelectList(db.TipoArreglo, "id", "Nombre", precio.idArreglo);
            ViewBag.idTipoPrenda = new SelectList(db.TipoPrenda, "id", "Nombre", precio.idTipoPrenda);
            return View(precio);
        }

        // GET: Precios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Precio precio = db.Precio.Find(id);
            if (precio == null)
            {
                return HttpNotFound();
            }
            ViewBag.idArreglo = new SelectList(db.TipoArreglo, "id", "Nombre", precio.idArreglo);
            ViewBag.idTipoPrenda = new SelectList(db.TipoPrenda, "id", "Nombre", precio.idTipoPrenda);
            return View(precio);
        }

        // POST: Precios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idTipoPrenda,idArreglo,Cantidad")] Precio precio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(precio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idArreglo = new SelectList(db.TipoArreglo, "id", "Nombre", precio.idArreglo);
            ViewBag.idTipoPrenda = new SelectList(db.TipoPrenda, "id", "Nombre", precio.idTipoPrenda);
            return View(precio);
        }

        // GET: Precios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Precio precio = db.Precio.Find(id);
            if (precio == null)
            {
                return HttpNotFound();
            }
            return View(precio);
        }

        // POST: Precios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Precio precio = db.Precio.Find(id);
            db.Precio.Remove(precio);
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
