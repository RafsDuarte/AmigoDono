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
        RepositoryPet _RepositoryPet;
        RepositoryAmigo _RepositoryAmigo;
        RepositoryTratamento _Repository;
        public CTratamento()
        {
            _RepositoryAmigo = new RepositoryAmigo();
            _RepositoryPet = new RepositoryPet();
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
        public List<PET> Pets()
        {
            return _RepositoryPet.SelecionarTodosPets();
        }
        public List<AMIGO> Amigos()
        {
            return _RepositoryAmigo.SelecionarTodosAmigos();
        }
        public List<vw_TRATAMENTO> NomePet(string NomePet)
        {
            return _Repository.SelecionarNomePet( NomePet);
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
