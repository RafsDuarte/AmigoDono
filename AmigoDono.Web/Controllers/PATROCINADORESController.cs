using AmigoDono.Model;
using AmigoDono.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmigoDono.Web.Controllers
{
    public class PATROCINADORESController : Controller
    {
        RepositoryAmigo _RepositoryAmigo;

        public PATROCINADORESController()
        {
             _RepositoryAmigo = new RepositoryAmigo();

        }

        // GET: PATROCINADORES
        public ActionResult Patrocinadores()
        {
            List<AMIGO> ListarAmigos = _RepositoryAmigo.ListarAmigos();
            return View(ListarAmigos);
        }
    }
}