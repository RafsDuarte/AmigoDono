using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
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
        public ActionResult Create(AMIGO oAmigo, HttpPostedFileBase imagem)
        {

            if (ModelState.IsValid)
            {

                // Upload Imagem
                string path = String.Empty;
                string pic = String.Empty;

                if (imagem != null)
                {
                    pic = Path.GetFileName(imagem.FileName);
                    path = Path.Combine(Server.MapPath("~/Content/imagens"), pic);
                    imagem.SaveAs(pic);
           
                }

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
