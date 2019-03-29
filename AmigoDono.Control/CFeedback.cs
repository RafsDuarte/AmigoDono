using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoDono.Model;
using AmigoDono.Model.Repositories;

namespace AmigoDono.Control
{
    public class CFeedback
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
    }
}
