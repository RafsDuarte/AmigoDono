using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmigoDono.Model;
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

        // GET: Home
        public ActionResult Index()
        {
            List<vw_PET> Pets = _Repository.ListarPets();
            return View(Pets);
        }

        public ActionResult CapturarAmigo()
        {
        //    if (Session["logado"] == null)
        //    {
        //        if ((bool)Session["logado"] == true)
        //        {
        //            ViewBag.Mensagem = "Amigo Capturado!";
        //        }
        //        else
        //        {
        //            return RedirectToAction("Signin", "Login");
        //        }
        //    }
            return View();
        }
    }
}