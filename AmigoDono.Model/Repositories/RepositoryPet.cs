﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model.Repositories
{
    public class RepositoryPet :IDisposable
    {
        private Amigos_do_DonoEntities odb;
        private bool LiberaContexto = false;
        private CONTROLE _Controle = new CONTROLE();

        public RepositoryPet()
        {
            odb = Helper.Data.getContexto();
            LiberaContexto = true;
        }
        public RepositoryPet(Amigos_do_DonoEntities _obd) { _obd = odb; }
        public PET Selecionar(int? ID)
        {
            return (from p in odb.PET where p.IDP == ID select p).FirstOrDefault();
        }     
        public PET SelecionarID(int ID)
        {
            return (from p in odb.PET where p.IDP == ID select p).FirstOrDefault();
        }
        public PET SelecionarNome(string NomePet)
        {
            return (from p in odb.PET where p.NomePet.Equals(NomePet) select p).FirstOrDefault();
        }
        public List<PET> SelecionarTodos(string pet)
        {
            if (pet.Trim() == "")
            {
                return (from p in odb.PET orderby p.NomePet select p).ToList();
            }
            else
            {
                return (from p in odb.PET where p.NomePet.Contains(pet) select p).ToList();
            }
        }

        public List<PET> SelecionarTodosPets()
        {
            return odb.PET.OrderBy(p => p.NomePet).ToList();
        }

        public List<vw_PET> ListarPets()
        {
            return odb.vw_PET.OrderBy(p => p.NomePet).ToList();
        }

        public void Incluir(PET oPet)
        {
            odb.PET.Add(oPet);
            odb.SaveChanges();
        }
        public void Alterar(PET oPet, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oPet).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }
        public void Excluir(PET oPet)
        {
            odb.PET.Attach(oPet);
            odb.PET.Remove(oPet);
            odb.SaveChanges();
        }

        public void Controle(int id)
        {
       //     odb.spc_Controle(id);
    
        }

        public void Dispose()
        {
            if (LiberaContexto)
            {
                odb.Dispose();
            }
        }
       

    }
}
