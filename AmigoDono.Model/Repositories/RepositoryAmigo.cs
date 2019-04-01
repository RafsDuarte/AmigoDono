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

        public List<AMIGO> SelecionarTodosAmigos()
        {
            return odb.AMIGO.OrderBy(p => p.Nome).ToList();
        }

        public void Incluir(AMIGO oAmigo)
        {
            odb.AMIGO.Add(oAmigo);
            odb.SaveChanges();
        }

        public void Alterar(AMIGO oAmigo, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oAmigo).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(AMIGO oAmigo)
        {
            odb.AMIGO.Attach(oAmigo);
            odb.AMIGO.Remove(oAmigo);
            odb.SaveChanges();
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
