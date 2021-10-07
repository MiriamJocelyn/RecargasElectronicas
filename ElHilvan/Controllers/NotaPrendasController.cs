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
    public class NotaPrendasController : Controller
    {
        private ElHilvanEntities db = new ElHilvanEntities();

        // GET: NotaPrendas
        public ActionResult Index()
        {
            var notaPrenda = db.NotaPrenda.Include(n => n.Precio).Include(n => n.Prenda);
            return View(notaPrenda.ToList());
        }

        // GET: NotaPrendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotaPrenda notaPrenda = db.NotaPrenda.Find(id);
            if (notaPrenda == null)
            {
                return HttpNotFound();
            }
            return View(notaPrenda);
        }

        // GET: NotaPrendas/Create
        public ActionResult Create()
        {
            ViewBag.idPrecio = new SelectList(db.Precio, "id", "id");
            ViewBag.idPrenda = new SelectList(db.Prenda, "id", "Descripcion");
            return View();
        }

        // POST: NotaPrendas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idNota,idPrenda,idPrecio")] NotaPrenda notaPrenda)
        {
            if (ModelState.IsValid)
            {
                db.NotaPrenda.Add(notaPrenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPrecio = new SelectList(db.Precio, "id", "id", notaPrenda.idPrecio);
            ViewBag.idPrenda = new SelectList(db.Prenda, "id", "Descripcion", notaPrenda.idPrenda);
            return View(notaPrenda);
        }

        // GET: NotaPrendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotaPrenda notaPrenda = db.NotaPrenda.Find(id);
            if (notaPrenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPrecio = new SelectList(db.Precio, "id", "id", notaPrenda.idPrecio);
            ViewBag.idPrenda = new SelectList(db.Prenda, "id", "Descripcion", notaPrenda.idPrenda);
            return View(notaPrenda);
        }

        // POST: NotaPrendas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idNota,idPrenda,idPrecio")] NotaPrenda notaPrenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notaPrenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPrecio = new SelectList(db.Precio, "id", "id", notaPrenda.idPrecio);
            ViewBag.idPrenda = new SelectList(db.Prenda, "id", "Descripcion", notaPrenda.idPrenda);
            return View(notaPrenda);
        }

        // GET: NotaPrendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotaPrenda notaPrenda = db.NotaPrenda.Find(id);
            if (notaPrenda == null)
            {
                return HttpNotFound();
            }
            return View(notaPrenda);
        }

        // POST: NotaPrendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NotaPrenda notaPrenda = db.NotaPrenda.Find(id);
            db.NotaPrenda.Remove(notaPrenda);
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
