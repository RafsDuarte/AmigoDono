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
        public int? BuscaQtdAnimal()
        {
            return (from p in odb.CONTADOR select p.Totaldotados).FirstOrDefault();
        }
        public int? BuscaQtdAnimalDisp()
        {
            return (from p in odb.CONTADOR select p.TotalDisposiçao).FirstOrDefault();
        }
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

        public void Incluir(CONTROLE oControle)
        {
            odb.CONTROLE.Add(oControle);
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
