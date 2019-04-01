using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model.Repositories
{
    public class RepositoryFeedback :IDisposable
    {
        private Amigos_do_DonoEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryFeedback()
        {
            odb = Helper.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryFeedback(Amigos_do_DonoEntities _obd)
        {
            _obd = odb;
        }

        // ok
        public FEEDBACK SelecionarNome(string Nome)
        {
            return (from p in odb.FEEDBACK where p.Nome.Equals(Nome) select p).FirstOrDefault();
        }

        public FEEDBACK SelecionarID(int ID)
        {
            return (from p in odb.FEEDBACK where p.IDF == ID select p).FirstOrDefault();
        }
        
        public FEEDBACK Selecionar(int ID)
        {
            return (from p in odb.FEEDBACK where p.IDF == ID select p).FirstOrDefault();
        }

        public FEEDBACK Selecionar(int? ID)
        {
            return (from p in odb.FEEDBACK where p.IDF == ID select p).FirstOrDefault();
        }
        // ok
        public List<FEEDBACK> SelecionarTodos(string feedback)
        {
            if(feedback.Trim() == "")
            {
                return (from p in odb.FEEDBACK orderby p.Nome select p).ToList();
            }
            else
            {
                return (from p in odb.FEEDBACK where p.Nome.Contains(feedback) select p).ToList();
            }
        }

        public void Incluir(FEEDBACK oFeedback)
        {
            //var local = odb.Set<AMIGO>()

            //             .Local

            //             .FirstOrDefault(f => f.IDA == oAmigo.IDA);

            //odb.Entry(local).State = System.Data.Entity.EntityState.Detached;

            //odb.Entry(oAmigo).State = System.Data.Entity.EntityState.Added;

            //odb.SaveChanges();


            //odb.Entry(oAmigo).State = System.Data.Entity.EntityState.Added;
            odb.FEEDBACK.Add(oFeedback);
            odb.SaveChanges();
        }

        public void Alterar(FEEDBACK ofeedback, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(ofeedback).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(FEEDBACK oFeedback)
        {
            odb.FEEDBACK.Attach(oFeedback);
            odb.FEEDBACK.Remove(oFeedback);
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
