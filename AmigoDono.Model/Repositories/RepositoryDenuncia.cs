using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoDono.Model;


namespace AmigoDono.Model.Repositories
{
    public class RepositoryDenuncia :IDisposable
    {
        private AmigoDonoEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryDenuncia()
        {
            odb = Helper.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryDenuncia(AmigoDonoEntities _obd)
        {
            _obd = odb;
        }
        public DENUNCIA SelecionarNome(string denunciante)
        {
            return (from p in odb.DENUNCIA where p.Denunciante.Equals(denunciante) select p).FirstOrDefault();
        }
        public DENUNCIA SelecionarID(int ID)
        {
            return (from p in odb.DENUNCIA where p.IDD == ID select p).FirstOrDefault();
        }

        public DENUNCIA Selecionar(int? ID)
        {
            return (from p in odb.DENUNCIA where p.IDD == ID select p).FirstOrDefault();
        }

        public List<DENUNCIA> SelecionarTodos()
        {
            return (from p in odb.DENUNCIA orderby p.Denunciante select p).ToList();
        }
        public List<DENUNCIA> SelecionarTodos(string denuncia)
        {
            if (denuncia.Trim() == "")
            {
                return (from p in odb.DENUNCIA orderby p.Denunciante select p).ToList();
            }
            else
            {
                return (from p in odb.DENUNCIA where p.Denunciante.Contains(denuncia) select p).ToList();
            }
        }
        public void Incluir(DENUNCIA oDenuncia)
        {
            odb.DENUNCIA.Add(oDenuncia);
            odb.SaveChanges();
        }

        public void Alterar(DENUNCIA oDenuncia, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oDenuncia).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(DENUNCIA oDenuncia)
        {
            odb.DENUNCIA.Attach(oDenuncia);
            odb.DENUNCIA.Remove(oDenuncia);
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
