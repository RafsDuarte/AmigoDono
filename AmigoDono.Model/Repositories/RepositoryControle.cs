using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model.Repositories
{
    public class RepositoryControle :IDisposable
    {
        private Amigos_do_DonoEntities odb;
        private bool LiberaContexto = false;
        public RepositoryControle()
        {
            odb = Helper.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryControle(Amigos_do_DonoEntities _obd)
        {
            _obd = odb;
        }

        // ok
        //public CONTROLE SelecionarNome(string Nome)
        //{
        //    return (from p in odb.CONTROLE where p.Nome.Equals(Nome) select p).FirstOrDefault();
        //}

        public CONTROLE SelecionarID(int ID)
        {
            return (from p in odb.CONTROLE where p.IDC == ID select p).FirstOrDefault();
        }

        public CONTROLE Selecionar(int ID)
        {
            return (from p in odb.CONTROLE where p.IDC == ID select p).FirstOrDefault();
        }

        public CONTROLE Selecionar(int? ID)
        {
            return (from p in odb.CONTROLE where p.IDC == ID select p).FirstOrDefault();
        }
        // ok
        //public List<CONTROLE> SelecionarTodos(string controle)
        //{
        //    if (controle.Trim() == "")
        //    {
        //        return (from p in odb.CONTROLE orderby p.Nome select p).ToList();
        //    }
        //    else
        //    {
        //        return (from p in odb.CONTROLE where p.Nome.Contains(controle) select p).ToList();
        //    }
        //}

        public void Incluir(CONTROLE oContrle)
        {
            //var local = odb.Set<AMIGO>()

            //             .Local

            //             .FirstOrDefault(f => f.IDA == oAmigo.IDA);

            //odb.Entry(local).State = System.Data.Entity.EntityState.Detached;

            //odb.Entry(oAmigo).State = System.Data.Entity.EntityState.Added;

            //odb.SaveChanges();


            //odb.Entry(oAmigo).State = System.Data.Entity.EntityState.Added;
            odb.CONTROLE.Add(oContrle);
            odb.SaveChanges();
        }

        public void Alterar(CONTROLE oControle, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oControle).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(CONTROLE oControle)
        {
            odb.CONTROLE.Attach(oControle);
            odb.CONTROLE.Remove(oControle);
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
