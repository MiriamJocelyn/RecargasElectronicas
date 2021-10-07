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
    public class TipoPrendasController : Controller
    {
        private ElHilvanEntities db = new ElHilvanEntities();

        // GET: TipoPrendas
        public ActionResult Index()
        {
            return View(db.TipoPrenda.ToList());
        }

        // GET: TipoPrendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPrenda tipoPrenda = db.TipoPrenda.Find(id);
            if (tipoPrenda == null)
            {
                return HttpNotFound();
            }
            return View(tipoPrenda);
        }

        // GET: TipoPrendas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoPrendas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Nombre")] TipoPrenda tipoPrenda)
        {
            if (ModelState.IsValid)
            {
                db.TipoPrenda.Add(tipoPrenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoPrenda);
        }

        // GET: TipoPrendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPrenda tipoPrenda = db.TipoPrenda.Find(id);
            if (tipoPrenda == null)
            {
                return HttpNotFound();
            }
            return View(tipoPrenda);
        }

        // POST: TipoPrendas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Nombre")] TipoPrenda tipoPrenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoPrenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoPrenda);
        }

        // GET: TipoPrendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPrenda tipoPrenda = db.TipoPrenda.Find(id);
            if (tipoPrenda == null)
            {
                return HttpNotFound();
            }
            return View(tipoPrenda);
        }

        // POST: TipoPrendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoPrenda tipoPrenda = db.TipoPrenda.Find(id);
            db.TipoPrenda.Remove(tipoPrenda);
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
