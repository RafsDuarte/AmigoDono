using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model.Helper
{
    public class Data
    {
        public static AmigoDonoEntities getContexto()
        {
            AmigoDonoEntities odb = new AmigoDonoEntities(); // instancia a conexão com o Banco de dados
            odb.Configuration.ProxyCreationEnabled = false; // desabilita o proxy
            return odb; // retorna a conexão com Banco de Dados
        }
    }
}
