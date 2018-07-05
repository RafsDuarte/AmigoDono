using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model.Repositories
{
    public class RepositoryAmigo :IDisposable
    {
        private AmigoDonoEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryAmigo()
        {
            odb = Helper.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryAmigo(AmigoDonoEntities _obd)
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

        public AMIGO SelecionaSenha(string senha)
        {
            return (from p in odb.AMIGO where p.Senha == senha select p).FirstOrDefault();
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

        public void Incluir(AMIGO oAmigo)
        {
            //var local = odb.Set<AMIGO>()

            //             .Local

            //             .FirstOrDefault(f => f.IDA == oAmigo.IDA);

            //odb.Entry(local).State = System.Data.Entity.EntityState.Detached;

            //odb.Entry(oAmigo).State = System.Data.Entity.EntityState.Added;

            //odb.SaveChanges();


            //odb.Entry(oAmigo).State = System.Data.Entity.EntityState.Added;
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
