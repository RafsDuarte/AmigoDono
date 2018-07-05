using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AmigoDono.Model;

namespace AmigoDono.Web.Controllers
{
    public class DENUNCIAController : Controller
    {
        private AmigoDonoEntities db = new AmigoDonoEntities();

        // GET: DENUNCIA
        public ActionResult Index()
        {
            return View(db.DENUNCIA.ToList());
        }

     

        // GET: DENUNCIA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DENUNCIA/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDD,Denunciante,TextoDenuncia,Email,CEP,TipoLogradouro,NomeLogradouro,Numero,Complemento,Bairro,Cidade,UF,Data,DataResposta")] DENUNCIA dENUNCIA)
        {
            if (ModelState.IsValid)
            {
                db.DENUNCIA.Add(dENUNCIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dENUNCIA);
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
