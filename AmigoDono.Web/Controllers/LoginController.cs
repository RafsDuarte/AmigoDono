using AmigoDono.Model;
using AmigoDono.Model.Helper;
using AmigoDono.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmigoDono.Web.Controllers
{
    public class LoginController : Controller
    {
        RepositoryAmigo repositoryAmigo = new RepositoryAmigo();
        // GET: Login
        public ActionResult Signin()
        {
            return View();
        }

        public ActionResult Realiza(AMIGO amigo)
        {
            if (!ModelState.IsValid)
            {
                return View(amigo);
            }
                 Boolean VerificaSenha = VerificaUsuario.AutorizaAmigo(amigo.Senha);
                if (VerificaSenha)
                {
                   return RedirectToAction("Index", "Adocao");
                }
   
                else
                {
                    ModelState.AddModelError("", "Login Inválido");
                }

            return RedirectToAction("Index", "Login");
        }
    }
}