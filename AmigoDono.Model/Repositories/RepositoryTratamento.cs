using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model.Repositories
{
    public class RepositoryTratamento : IDisposable
    {
        private Amigos_do_DonoEntities odb;
        private bool LiberaContexto = false;
        public RepositoryTratamento()
        {
            odb = Helper.Data.getContexto();
            LiberaContexto = true;
        }
        public RepositoryTratamento(Amigos_do_DonoEntities _obd) { _obd = odb; }
        public TRATAMENTO Selecionar(int ID)
        {
            return (from p in odb.TRATAMENTO where p.IDT == ID select p).FirstOrDefault();
        }
        public TRATAMENTO SelecionarID(int ID)
        {
            return (from p in odb.TRATAMENTO where p.IDT == ID select p).FirstOrDefault();
        }
        //public TRATAMENTO SelecionarNome(string NomeTratamento)
        //{
        //    return (from p in odb.TRATAMENTO where p.NomeTratamento.Equals(NomeTratamento) select p).FirstOrDefault();
        //}
        //public List<TRATAMENTO> SelecionarTodos(string tratamento)
        //{
        //    if (tratamento.Trim() == "")
        //    {
        //        return (from p in odb.TRATAMENTO orderby p.NomeTratamento select p).ToList();
        //    }
        //    else
        //    {
        //        return (from p in odb.TRATAMENTO where p.NomeTratamento.Contains(tratamento) select p).ToList();
        //    }
        //}
        public void Incluir(TRATAMENTO oTratamento)
        {
            odb.TRATAMENTO.Add(oTratamento);
            odb.SaveChanges();
        }
        public void Alterar(TRATAMENTO oTratamento, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oTratamento).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }
        public void Excluir(TRATAMENTO oTratamento)
        {
            odb.TRATAMENTO.Attach(oTratamento);
            odb.TRATAMENTO.Remove(oTratamento);
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
