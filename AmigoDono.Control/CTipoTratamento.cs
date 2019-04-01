using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoDono.Model;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Control
{
    public class CTipoTratamento :IDisposable
    {
        RepositoryTipoTratamento _Repository;
        public CTipoTratamento()
        {
            _Repository = new RepositoryTipoTratamento();
        }
        public void Incluir(TIPOTRATAMENTO oTipoTratamento)
        {
            _Repository.Incluir(oTipoTratamento);
        }
        public void Excluir(TIPOTRATAMENTO oTipoTratamento)
        {
            _Repository.Excluir(oTipoTratamento);
        }
        public TIPOTRATAMENTO Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }
        public TIPOTRATAMENTO SelecionarID(int ID)
        {
            return _Repository.SelecionarIDTT(ID);
        }

        public List<TIPOTRATAMENTO> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }
        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
