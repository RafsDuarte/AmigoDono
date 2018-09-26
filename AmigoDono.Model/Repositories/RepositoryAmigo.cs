using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model.Repositories
{
    public class RepositoryAmigo :IDisposable
    {
        private Amigos_do_DonoEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryAmigo()
        {
            odb = Helper.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryAmigo(Amigos_do_DonoEntities _obd)
        {
            _obd = odb;
        }

        // ok
        public AMIGO SelecionarNome(string Nome)
        {
            return (from p in odb.AMIGO where p.Nome.Equals(Nome) select p).FirstOrDefault();
        }

        //selecionar Amigo pelo email e senha
        public AMIGO VerificaLogin(string email, string senha)
        {
            return (from p in odb.AMIGO where p.Email.Equals(email) && p.Senha.Equals(senha) select p).FirstOrDefault();
        }

        public AMIGO VerificaUsuario(string email)
        {
            return (from p in odb.AMIGO where p.Email.Equals(email) select p).FirstOrDefault();
        }

        public AMIGO SelecionarID(int ID)
        {
            return (from p in odb.AMIGO where p.IDA == ID select p).FirstOrDefault();
        }
        
        public AMIGO Selecionar(int ID)
        {
            return (from p in odb.AMIGO where p.IDA == ID select p).FirstOrDefault();
        }

        public AMIGO Selecionar(int? ID)
        {
            return (from p in odb.AMIGO where p.IDA == ID select p).FirstOrDefault();
        }
        // ok

        public List<AMIGO> SelecionarTodos()
        {
            return (from p in odb.AMIGO orderby p.Nome select p).ToList();
           
        }
        public List<AMIGO> SelecionarTodos(string amigo)
        {
            if(amigo.Trim() == "")
            {
                return (from p in odb.AMIGO orderby p.Nome select p).ToList();
            }
            else
            {
                return (from p in odb.AMIGO where p.Nome.Contains(amigo) select p).ToList();
            }
        }

        public List<AMIGO> ListarAmigo()
        {
            return odb.AMIGO.OrderBy(p => p.Nome).ToList();
        }

        public List<AMIGO> ListarAmigos()
        {
            return (from p in odb.AMIGO /*where p.Funcao == "Pratocinador" */orderby p.Nome select p).ToList();
        }

        public AMIGO SelecionarPorEmail(string Email)
        {
            return odb.AMIGO.Where(p => p.Email.Equals(Email)).FirstOrDefault();
        }

        public void Incluir(AMIGO oAmigo)
        {
            Amigos_do_DonoEntities db = new Amigos_do_DonoEntities();

            db.AMIGO.Add(oAmigo);
            db.SaveChanges();

            db.Dispose();
        }

        public void Alterar(AMIGO oAmigo, bool attach = true)
        {
            Amigos_do_DonoEntities db = new Amigos_do_DonoEntities();
            if (attach)
            {
                db.Entry(oAmigo).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            db.Dispose();
        }

        public void Excluir(AMIGO oAmigo)
        {
            Amigos_do_DonoEntities db = new Amigos_do_DonoEntities();
            db.AMIGO.Attach(oAmigo);
            db.AMIGO.Remove(oAmigo);
            db.SaveChanges();
            db.Dispose();
        }

        public void Dispose()
        {
            if (LiberaContexto)
            {
                odb.Dispose();
            }
        }
    }
}
