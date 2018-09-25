using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Windows.Forms;
using AmigoDono.Model;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Web.Views
{
    public class DENUNCIAController : Controller
    {
        private RepositoryDenuncia _repositoryDenuncia = new RepositoryDenuncia();

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
        public ActionResult Create([Bind(Include = "IDD,Denunciante,TextoDenuncia,Email,CEP,TipoLogradouro,NomeLogradouro,Numero,Complemento,Bairro,Cidade,UF,Data,DataResposta")] DENUNCIA oDenuncia)
        {
            

            if (ModelState.IsValid)
            {
                _repositoryDenuncia.Incluir(oDenuncia);
                return RedirectToAction("Index", "Home");
            }

            return View(oDenuncia);
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repositoryDenuncia.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
