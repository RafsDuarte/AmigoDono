using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoDono.Model;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Control
{
    public class CTratamento :IDisposable
    {
        RepositoryTratamento _Repository;
        public CTratamento()
        {
            _Repository = new RepositoryTratamento();
        }
        public void Incluir(TRATAMENTO oTratamento)
        {
            _Repository.Incluir(oTratamento);
        }
        //public void Alterar(TRATAMENTO oPet, bool attach = true)
        //{
        //    _Repository.Alterar(oTratamento, attach);
        //}

        public void Excluir(TRATAMENTO oTratamento)
        {
            _Repository.Excluir(oTratamento);
        }
        //public List<TRATAMENTO> SelecionarTodos(string Tratamento)
        //{
        //    return _Repository.SelecionarTodos(Tratamento);
        //}

        public TRATAMENTO Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }
        public TRATAMENTO SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        //public TRATAMENTO SelecionarNome(string Nome)
        //{
        //    return _Repository.SelecionarNome(Nome);
        //}

        public void Dispose()
        {
            _Repository.Dispose();
        }





    }
}
