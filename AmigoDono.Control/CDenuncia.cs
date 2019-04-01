using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoDono.Model;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Control
{
    public class CDenuncia :IDisposable
    {
        RepositoryDenuncia _Repository;
        public CDenuncia()
        {
            _Repository = new RepositoryDenuncia();
        }
        public void Incluir (DENUNCIA oDenuncia)
        {
            _Repository.Incluir(oDenuncia);
        }
        public void Alterar (DENUNCIA oDenuncia, bool attach = true)
        {
            _Repository.Alterar(oDenuncia, attach);
        }
        public void Excluir (DENUNCIA oDenuncia)
        {
            _Repository.Excluir(oDenuncia);
        }
        public List<DENUNCIA> SelecionarTodos(string denuncia)
        {
            return _Repository.SelecionarTodos(denuncia);
        }
        public DENUNCIA Selecionar ( int ID)
        {
            return _Repository.Selecionar(ID);
        }
        public DENUNCIA SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        } public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
