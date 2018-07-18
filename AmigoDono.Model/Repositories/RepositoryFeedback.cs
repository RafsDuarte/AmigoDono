using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model.Repositories
{
    public class RepositoryFeedback : IDisposable
    {
        private AmigoDonoEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryFeedback()
        {
            odb = Helper.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryFeedback(AmigoDonoEntities _obd)
        {
            _obd = odb;
        }

        public void Incluir(FEEDBACK oFeedback)
        {

            odb.FEEDBACK.Add(oFeedback);
            odb.SaveChanges();
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
