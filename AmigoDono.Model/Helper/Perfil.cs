using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web;

namespace AmigoDono.Model.Helper
{
    public class Perfil
    {
        public Perfil(string pEmail)
        {
            this.Email = pEmail;
            if (pEmail == "rafinha.lduarte@hotmail.com")
            {
                Roles = new string[] { "Usuario" };
            }
            else
            {
                // coment// coment
                Roles = new string[] { "Usuario" };
            }
        }

        public string Email { get; set; }
        public string[] Roles;
    }
}
