using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model.Repositories
{
    public class RepositoryTipoTratamento : IDisposable
    {
        private Amigos_do_DonoEntities odb;
        private bool LiberaContexto = false;
        public RepositoryTipoTratamento()
        {
            odb = Helper.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryTipoTratamento(Amigos_do_DonoEntities _obd)
        {
            _obd = odb;
        }

        // ok
        public TIPOTRATAMENTO SelecionarDescricao(string Descricao)
        {
            return (from p in odb.TIPOTRATAMENTO where p.Descricao.Equals(Descricao) select p).FirstOrDefault();
        }

        public TIPOTRATAMENTO SelecionarIDTT(int ID)
        {
            return (from p in odb.TIPOTRATAMENTO where p.IDTT == ID select p).FirstOrDefault();
        }
        
        public TIPOTRATAMENTO Selecionar(int ID)
        {
            return (from p in odb.TIPOTRATAMENTO where p.IDTT == ID select p).FirstOrDefault();
        }

        public TIPOTRATAMENTO Selecionar(int? ID)
        {
            return (from p in odb.TIPOTRATAMENTO where p.IDTT == ID select p).FirstOrDefault();
        }
        // ok
        public List<TIPOTRATAMENTO> SelecionarTodos()
        {           
                return (from p in odb.TIPOTRATAMENTO orderby p.IDTT select p).ToList();
        
              
        }

        public void Incluir(TIPOTRATAMENTO oTipoTratamento)
        {
            odb.TIPOTRATAMENTO.Add(oTipoTratamento);
            odb.SaveChanges();
        }

        public void Alterar(TIPOTRATAMENTO oTipoTratamento, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oTipoTratamento).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(TIPOTRATAMENTO oTipoTratamento)
        {
            odb.TIPOTRATAMENTO.Attach(oTipoTratamento);
            odb.TIPOTRATAMENTO.Remove(oTipoTratamento);
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
