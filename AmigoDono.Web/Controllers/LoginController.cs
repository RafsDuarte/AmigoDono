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

        private bool VerificaLogin(/*string Email, string Senha*/ string Email, string Senha)
        {
<<<<<<< HEAD
            AMIGO oAmigo = repositoryAmigo.VerificaLogin(Email, Senha);
            if ( oAmigo != null)
            {
                ViewBag.Nome = oAmigo.Nome;
                return true;
=======

            List<AMIGO> Amigos = repositoryAmigo.SelecionarTodos();
            foreach (var x in Amigos)
            {
                if (x.Email == Email && x.Senha == Senha)
                {

                    return true;
                }

>>>>>>> 4640b62f63d718f6d656c88f3f6ffda15efc6f2d
            }
            return false;
        }

        [HttpPost]

        public ActionResult RealizaLogin(/*string Email, string Senha*/ Login oLogin)
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
<<<<<<< HEAD
                    
=======
>>>>>>> 4640b62f63d718f6d656c88f3f6ffda15efc6f2d
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
