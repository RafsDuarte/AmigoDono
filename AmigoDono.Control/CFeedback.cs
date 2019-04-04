using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoDono.Model;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Control
{
    public class CFeedback :IDisposable
    {
        RepositoryFeedback _Repository;
        public CFeedback()
        {
            _Repository = new RepositoryFeedback();
        }
        public void Incluir(FEEDBACK oFeedback)
        {
            _Repository.Incluir(oFeedback);
        }
        public void Excluir(FEEDBACK oFeedback)
        {
            _Repository.Excluir(oFeedback);
        }
        public FEEDBACK Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }
        public FEEDBACK SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }
        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
