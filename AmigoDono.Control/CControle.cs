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
        RepositoryPet _RepositoryPet;
        RepositoryAmigo _RepositoryAmigo;
        
        public CControle()
        {
            _RepositoryPet = new RepositoryPet();
            _Repository = new RepositoryControle();
            _RepositoryAmigo = new RepositoryAmigo();
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

        public CONTROLE Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

        public List<PET> Pets()
        {
            return _RepositoryPet.SelecionarTodosPets();

        }

        public List<AMIGO> Amigos()
        {
            return _RepositoryAmigo.SelecionarTodosAmigos();
        }

        public int? BuscaQtdAnimal()
        {
            return _Repository.BuscaQtdAnimal();
        }
        public int? BuscaQtdAnimalDisposicao()
        {
            return _Repository.BuscaQtdAnimalDisp();
        }
    }
}
