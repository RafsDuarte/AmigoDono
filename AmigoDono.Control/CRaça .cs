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
        RepositoryRaça _Repository;
        public CRaça()
        {
            _Repository = new RepositoryRaça();
        }
        public void Incluir(RAÇA oRaça)
        {
            _Repository.Incluir(oRaça);
        }

        public void Excluir(RAÇA oRaça)
        {
            _Repository.Excluir(oRaça);
        }
        public RAÇA Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }
        public RAÇA SelecionarIDR(int ID)
        {
            return _Repository.SelecionarIDR(ID);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }





    }
}
