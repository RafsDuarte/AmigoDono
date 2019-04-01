using AmigoDono.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model.Helper
{
    public class VerificaUsuario
    {
        public static Boolean AutorizaAmigo(string senha)
        {
            RepositoryAmigo repositoryAmigo = new RepositoryAmigo();
            AMIGO amigo = new AMIGO();
            amigo = repositoryAmigo.SelecionaSenha(senha);
            if (amigo !=null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
