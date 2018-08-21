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


        // GET: AMIGO
            public ActionResult Index()
        {
            return View(_repositoryAmigo.SelecionarTodos());
        }

        //// GET: AMIGO/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AMIGO aMIGO = db.AMIGO.Find(id);
        //    if (aMIGO == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(aMIGO);
        //}

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
        public ActionResult Create([Bind(Include = "IDA,Nome,Funcao,Senha,CPF,CNPJ,DataNascimento,DataCadastro,Email,CEP,Logradouro,NomeLogradouro,Numero,Complemento,Bairro,Cidade,UF,Telefone,Celular,Ajuda,Imagem")] AMIGO oAmigo, HttpPostedFileBase imagem, string chkRemoverImagem)
        {
            try
            {
                if (ModelState.IsValid)
                { if (chkRemoverImagem != null)
                    {
                        oAmigo.Imagem = null;
                    }

                    if (imagem != null)
                    {
                        
                        oAmigo.Imagem = SetImagem(imagem);
                    }

                    _repositoryAmigo.Incluir(oAmigo);
                    return RedirectToAction("Index");
                }
               
                return View(oAmigo);
            }
            catch
            {
                return View(oAmigo);
            }
        }

        // GET: AMIGO/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AMIGO aMIGO = db.AMIGO.Find(id);
        //    if (aMIGO == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(aMIGO);
        //}

        //// POST: AMIGO/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "IDA,Nome,Funcao,Senha,CPF,CNPJ,DataNascimento,DataCadastro,Email,CEP,Logradouro,NomeLogradouro,Numero,Complemento,Bairro,Cidade,UF,Telefone,Celular,Ajuda,Imagem")] AMIGO aMIGO)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(aMIGO).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(aMIGO);
        //}

        //// GET: AMIGO/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AMIGO aMIGO = db.AMIGO.Find(id);
        //    if (aMIGO == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(aMIGO);
        //}

        //// POST: AMIGO/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    AMIGO aMIGO = db.AMIGO.Find(id);
        //    db.AMIGO.Remove(aMIGO);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
