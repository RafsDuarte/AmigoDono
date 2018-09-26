using AmigoDono.Model;
using AmigoDono.Model.Helper;
using AmigoDono.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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

        public ActionResult Signout()
        {
            Session.RemoveAll();
            return RedirectToAction("Index", "Home");
        }

        private bool VerificaLogin(string Email, string Senha)
        {
            AMIGO oAmigo = repositoryAmigo.VerificaLogin(Email, Senha);
            if (oAmigo != null)
            {
                return true;
            }

            return false;
        }

        [HttpPost]

        public ActionResult RealizaLogin(Login oLogin)
        {
            if (ModelState.IsValid)
            {
                if (VerificaLogin(oLogin.Email, oLogin.Senha))
                {
                    Perfil oPerfil = new Perfil(oLogin.Email);
                    Session["Perfil"] = oPerfil;
                    // Cookie de autentificação que fica salvo para ser lido nas sessões.
                    FormsAuthentication.SetAuthCookie(oLogin.Email, false);
                    // Busca cookie de autentificação.
                    FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(1, oLogin.Email, DateTime.Now, DateTime.Now.AddDays(1), false, string.Join(",", oPerfil.Roles), "~/");
                    // Criptografa o cookie.
                    String encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                    
                    // Cria o cookie http.
                    string AuthCookieName = FormsAuthentication.FormsCookieName;
                    HttpCookie AuthCookie = new HttpCookie(AuthCookieName, encryptedTicket);
                    // Adiciona o cookie no cliente.
                    Response.Cookies.Add(AuthCookie);
                    // Se estiver autenticado, redireciona para a Home.
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Mensagem = "Email ou senha incorretos!";
                    return View("Signin");
                }
            }
            return View();
        }
    }
}
