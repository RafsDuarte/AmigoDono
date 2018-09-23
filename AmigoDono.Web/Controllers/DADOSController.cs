using AmigoDono.Model;
using AmigoDono.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmigoDono.Web.Controllers
{
    public class DADOSController : Controller
    {
        RepositoryAmigo _Repository;

        public DADOSController()
        {
            _Repository = new RepositoryAmigo();
        }

        // GET: DADOS
        public ActionResult Detalhes()
        {
            return View();
        }
    }
}