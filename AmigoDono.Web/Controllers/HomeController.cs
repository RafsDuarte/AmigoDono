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
        RepositoryControle _RepositoryC;
        RepositoryAmigo _RepositoryAmigo;

        public HomeController()
        {
            _Repository = new RepositoryPet();
            _RepositoryC = new RepositoryControle();
            _RepositoryAmigo = new RepositoryAmigo();
        }
        
        [Authorize]
        // GET: Home
        public ActionResult Index()
        {
            // Pega o usuário direto das variáveis de servidor.
            var Usuario = Request.ServerVariables["AUTH_USER"];

            // Quando a senha vai aberta, é possível lê-la através da variável Auth_Password.
            // Ela vai aberta no modo Autenficação Básica.
            // No modo Digest, vc não consegue capturá-la, mas ela é transmitida aberta também e é possível
            var senha = Request.ServerVariables["AUTH_PASSWORD"];

            // Busca atráves do objeto User.Identity, criado automaticamente no ASP.NET.
            var Usuario1 = System.Web.HttpContext.Current.User.Identity.Name;
            ViewBag.Nome = Usuario;
            //AMIGO aMIGO = _RepositoryAmigo.SelecionarPorEmail(Usuario);
            //ViewBag.ID = aMIGO.IDA;
            List<vw_PET> Pets = _Repository.ListarPets();
            return View(Pets);
        }

        public ActionResult CapturarAmigo(CONTROLE oControle )
        {
            ViewBag.Mensagem = "Parabéns! Você conseguiu um amiguinho!!";
            _RepositoryC.Incluir(oControle);
            return RedirectToAction("Index", "Home");
        }
    }
}