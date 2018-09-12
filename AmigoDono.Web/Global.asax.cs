using AmigoDono.Model.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace AmigoDono.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_End()
        {

        }

        protected void Session_Start()
        {

        }

        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            if (HttpContext.Current.User == null)
                return;
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
                return;
            if (HttpContext.Current.User.Identity is FormsIdentity)
            {
                //if (Context.Session != null && Context.Session["Perfil"] != null)
                //{
                // Perfil oPerfil = (Perfil)Context.Session["´Perfil"];
                var id = (FormsIdentity)HttpContext.Current.User.Identity;
                FormsAuthenticationTicket ticket = id.Ticket;
                // Pega as roles que estão em string separadas com vírgula do user data do ticket.

                string userData = ticket.UserData;
                // Cria um array com as roles
                string[] roles = userData.Split(',');
                // Readiciona o usuário com as roles

                HttpContext.Current.User = new GenericPrincipal(id, roles);

                // HttpContext.Current.User = new GenericPrincipal(id, oPerfil.Roles);
                //}

            }

        }
    }
}

