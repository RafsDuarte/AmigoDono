using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoDono.Model;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Control
{
    public class CPet :IDisposable
    {
        RepositoryPet _Repository;
        RepositoryRaça _RepositoryRaca;

        public CPet()
        {
            _Repository = new RepositoryPet();
            _RepositoryRaca = new RepositoryRaça();
        }

        public void Incluir(PET oPet)
        {
            _Repository.Incluir(oPet);
        }

        public void Alterar(PET oPet, bool attach = true)
        {
            _Repository.Alterar(oPet, attach);
        }

        public void Excluir(PET oPet)
        {
            _Repository.Excluir(oPet);
        }

        public List<PET> SelecionarTodos(string pet)
        {
            return _Repository.SelecionarTodos(pet);
        }

        public PET Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }
        public PET SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        public PET SelecionarNome(string Nome)
        {
            return _Repository.SelecionarNome(Nome);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

        public List<RAÇA> SelecionarTodasRacas()
        {
            return _RepositoryRaca.SelecionarRacas();
        }
        public void ProcdControle(int id)
        {
            _Repository.Controle(id);
        }
    }
}
