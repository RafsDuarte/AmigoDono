using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AmigoDono.Model;

namespace AmigoDono.Web.Views
{
    public class FEEDBACKController : Controller
    {
        private AmigoDonoEntities db = new AmigoDonoEntities();

        // GET: FEEDBACK
        public ActionResult Index()
        {
            return View(db.FEEDBACK.ToList());
        }

        // GET: FEEDBACK/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FEEDBACK fEEDBACK = db.FEEDBACK.Find(id);
            if (fEEDBACK == null)
            {
                return HttpNotFound();
            }
            return View(fEEDBACK);
        }

        // GET: FEEDBACK/Create
        public ActionResult FaleConosco()
        {
            return View();
        }

        // POST: FEEDBACK/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDF,Nome,Email,Opiniao,Feedback")] FEEDBACK fEEDBACK)
        {
            if (ModelState.IsValid)
            {
                db.FEEDBACK.Add(fEEDBACK);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fEEDBACK);
        }

        // GET: FEEDBACK/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FEEDBACK fEEDBACK = db.FEEDBACK.Find(id);
            if (fEEDBACK == null)
            {
                return HttpNotFound();
            }
            return View(fEEDBACK);
        }

        // POST: FEEDBACK/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDF,Nome,Email,Opiniao,Feedback")] FEEDBACK fEEDBACK)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fEEDBACK).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fEEDBACK);
        }

        // GET: FEEDBACK/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FEEDBACK fEEDBACK = db.FEEDBACK.Find(id);
            if (fEEDBACK == null)
            {
                return HttpNotFound();
            }
            return View(fEEDBACK);
        }

        // POST: FEEDBACK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FEEDBACK fEEDBACK = db.FEEDBACK.Find(id);
            db.FEEDBACK.Remove(fEEDBACK);
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
