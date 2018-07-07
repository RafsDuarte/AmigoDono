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
    public class AMIGOController : Controller
    {
        private AmigoDonoEntities db = new AmigoDonoEntities();

        // GET: AMIGO
        public ActionResult Index()
        {
            return View(db.AMIGO.ToList());
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
        public ActionResult Create([Bind(Include = "IDA,Nome,Funcao,Senha,CPF,CNPJ,DataNascimento,DataCadastro,Email,CEP,Logradouro,NomeLogradouro,Numero,Complemento,Bairro,Cidade,UF,Telefone,Celular,Ajuda,Imagem")] AMIGO aMIGO)
        {
            if (ModelState.IsValid)
            {
                db.AMIGO.Add(aMIGO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aMIGO);
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
