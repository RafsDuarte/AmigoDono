using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;

namespace AmigoDono.Web.Helper
{ 
    public static class ActiveDirectory
    {
        // Autentica em um domínio Active Directory ou na máquina local.
        public static bool Autentica(string Dominio, string Contexto, string Usuario, string Senha)
        {
            try
            {
                var _PrincipalContext = new PrincipalContext(ContextType.Machine);
                return _PrincipalContext.ValidateCredentials(Usuario, Senha);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
