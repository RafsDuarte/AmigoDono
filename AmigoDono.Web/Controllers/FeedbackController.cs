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
        private Amigos_do_DonoEntities db = new Amigos_do_DonoEntities();

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
        public ActionResult Create(FEEDBACK oFeedback)
        {
            if (ModelState.IsValid)
            {
                db.FEEDBACK.Add(oFeedback);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(oFeedback);
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
