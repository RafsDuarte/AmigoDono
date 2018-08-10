using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoDono.Model;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Control
{
    public class CRaça :IDisposable
    {
        RepositoryTratamento _Repository;
        public CRaça()
        {
            _Repository = new RepositoryTratamento();
        }
        public void Incluir(TRATAMENTO oTratamento)
        {
            _Repository.Incluir(oTratamento);
        }

        public void Excluir(TRATAMENTO oTratamento)
        {
            _Repository.Excluir(oTratamento);
        }
        public TRATAMENTO Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }
        public TRATAMENTO SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }





    }
}
