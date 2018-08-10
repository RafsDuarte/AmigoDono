using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoDono.Model;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Control
{
    public class CControle: IDisposable
    {
        RepositoryControle _Repository;
        public CControle()
        {
            _Repository = new RepositoryControle();
        }

        public void Incluir(CONTROLE oControle)
        {
            _Repository.Incluir(oControle);
        }

        public void Alterar(CONTROLE oControle, bool attach = false)
        {
            _Repository.Alterar(oControle, attach);
        }

        public void Excluir(CONTROLE oControle)
        {
            _Repository.Excluir(oControle);
        }

        //public List<vwControle> SelecionarTodos()
        //{
        //    return _Repository.SelecionarTodos();
        //}

        public CONTROLE Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}
