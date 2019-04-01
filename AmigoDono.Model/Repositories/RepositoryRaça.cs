using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model.Repositories
{
    public class RepositoryRaça :IDisposable
    {
        private Amigos_do_DonoEntities odb;
        private bool LiberaContexto = false;
        public RepositoryRaça()
        {
            odb = Helper.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryRaça(Amigos_do_DonoEntities _obd)
        {
            _obd = odb;
        }
        public RAÇA SelecionarNomeRaça(string NomeRaça)
        {
            return (from p in odb.RAÇA where p.NomeRaça.Equals(NomeRaça) select p).FirstOrDefault();
        }

        public RAÇA SelecionarIDR(int ID)
        {
            return (from p in odb.RAÇA where p.IDR == ID select p).FirstOrDefault();
        }
        
        public RAÇA Selecionar(int ID)
        {
            return (from p in odb.RAÇA where p.IDR == ID select p).FirstOrDefault();
        }

        public RAÇA Selecionar(int? ID)
        {
            return (from p in odb.RAÇA where p.IDR == ID select p).FirstOrDefault();
        }
        public List<RAÇA> SelecionarTodos(string raça)
        {
            if(raça.Trim() == "")
            {
                return (from p in odb.RAÇA orderby p.NomeRaça select p).ToList();
            }
            else
            {
                return (from p in odb.RAÇA where p.NomeRaça.Contains(raça) select p).ToList();
            }
        }

        public void Incluir(RAÇA oRaça)
        {
            odb.RAÇA.Add(oRaça);
            odb.SaveChanges();
        }

        public void Alterar(RAÇA oRaça, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oRaça).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(RAÇA oRaça)
        {
            odb.RAÇA.Attach(oRaça);
            odb.RAÇA.Remove(oRaça);
            odb.SaveChanges();
        }

        public void Dispose()
        {
            if (LiberaContexto)
            {
                odb.Dispose();
            }
        }

        public List<RAÇA> SelecionarRacas()
        {
            return odb.RAÇA.OrderBy(P => P.NomeRaça).ToList();
        }
    }
}
