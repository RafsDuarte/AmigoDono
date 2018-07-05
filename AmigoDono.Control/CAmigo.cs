using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoDono.Model;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Control
{
    public class CAmigo :IDisposable

    {
        RepositoryAmigo _Repository;

        public CAmigo()
        {
            _Repository = new RepositoryAmigo();
        }

        public void Incluir(AMIGO oAmigo)
        {
            _Repository.Incluir(oAmigo);
        }

        public void Alterar(AMIGO oAmigo, bool attach = true)
        {
            _Repository.Alterar(oAmigo, attach);
        }

        public void Excluir(AMIGO oAmigo)
        {
            _Repository.Excluir(oAmigo);
        }

        public List<AMIGO> SelecionarTodos(string amigo)
        {
            return _Repository.SelecionarTodos(amigo);
        }

        public AMIGO Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }

        public AMIGO SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        public AMIGO SelecionarNome(string Nome)
        {
             return _Repository.SelecionarNome(Nome);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
