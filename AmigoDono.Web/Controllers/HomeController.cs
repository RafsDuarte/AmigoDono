using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmigoDono.Model;
using AmigoDono.Model.Helper;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Web.Controllers
{
    public class HomeController : Controller
    {
        RepositoryPet _Repository;

        public HomeController()
        {
            _Repository = new RepositoryPet();
        }

        [Authorize]
        // GET: Home
        public ActionResult Index()
        {
            // Pega o usuário direto das variáveis do servidor;
            var Usuario = Request.ServerVariables["AUTH_USER"];

            // Quando a senha vai aberta, é possivel lê-la através da variável Auth_Password.
            // Ela vai aberta no modo de Autentificação Básica.
            // No modo Digest, vc não consegue capturá-la, mas ela é transmitida abert=a também e é postada.
            var Senha = Request.ServerVariables["AUTH_PASSWORD"];

            // Busca através do objeto User.Identity, criado automaticamente pelo ASP.Net.
            var Usuario1 = System.Web.HttpContext.Current.User.Identity.Name;

            ViewBag.Usuario = Usuario;
            List<vw_PET> Pets = _Repository.ListarPets();
            return View(Pets);
        }

        //[Authorize(Roles = "Administrador")]
        //public ActionResult CapturarAmigo(Perfil oPerfil)
        //{
        //    if (HttpContext.GetSection.Profile != null)
        //    {
        //        ViewBag.Mensagem = "Parabéns! Você conseguiu um amiguinho!!";
        //    }
        //    else
        //    {
        //        return RedirectToAction("Signin", "Login");
        //    }
        //    return View();
        //}
    }
}
