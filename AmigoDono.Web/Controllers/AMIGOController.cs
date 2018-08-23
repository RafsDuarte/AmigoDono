using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AmigoDono.Model;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Web.Views
{
    public class AMIGOController : Controller
    {
        private RepositoryAmigo _repositoryAmigo = new RepositoryAmigo();
        private byte[] SetImagem(HttpPostedFileBase Imagem)
        {
            var bytesimagem = new byte[Imagem.ContentLength]; Imagem.InputStream.Read(bytesimagem, 0, Imagem.ContentLength);
            return bytesimagem;
        }


        // GET: AMIGO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AMIGO/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AMIGO oAmigo, HttpPostedFileBase imagem, string chkRemoverImagem)
        {
           
                if (ModelState.IsValid)
                 { 
                //    if (chkRemoverImagem != null)
                //    {
                //        oAmigo.Imagem = null;
                //    }

                //    if (imagem != null)
                //    {                       
                //        oAmigo.Imagem = SetImagem(imagem);
                //    }

                    _repositoryAmigo.Incluir(oAmigo);
                    return RedirectToAction("Index", "Home");
                }
               
                return View(oAmigo);
            
            
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repositoryAmigo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
