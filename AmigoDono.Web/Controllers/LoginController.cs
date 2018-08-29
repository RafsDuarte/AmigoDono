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

        public ActionResult RealizaLogin(string Email,string Senha)
        {
            List<AMIGO> Amigos = repositoryAmigo.SelecionarTodos();
            foreach(var x in Amigos)
            {
                if(x.Email==Email && x.Senha==Senha)
                {
                    return View("Index", "Home");
                }
            }
            ViewBag.Mensagem = "Email ou senha incorretos!";
            return View("Signin", "Login"); 
        }
    }
}