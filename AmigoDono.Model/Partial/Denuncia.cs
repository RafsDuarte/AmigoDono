using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AmigoDono.Model

{
    [MetadataType(typeof(MD_DENUNCIA))]
    public partial class DENUNCIA
    {
        internal class MD_DENUNCIA
        {
            [DisplayName("ID")]
            public object IDD { get; set; }

            [DisplayName("Denunciante")]
            public object Denunciante { get; set; }

            [DisplayName("Denuncia")]
            public object TextoDenuncia { get; set; }

            [DisplayName("Email")]
            public object Email { get; set; }

            [DisplayName("CEP")]
            public object CEP { get; set; }

            [DisplayName("Logradouro")]
            public object TipoLogradouro { get; set; }

            [DisplayName("Nome Logradouro")]
            public object NomeLogradouro { get; set; }

            [DisplayName("Número")]
            public object Numero { get; set; }

            [DisplayName("Complemento")]
            public object Complemento { get; set; }

            [DisplayName("Bairro")]
            public object Bairro { get; set; }

            [DisplayName("Cidade")]
            public object Cidade { get; set; }

            [DisplayName("UF")]
            public object UF { get; set; }

            [DisplayName("Data")]
            public object DataDenuncia { get; set; }

            [DisplayName("Data Resposta")]
            public object DataResposta { get; set; }
        }
    }
}
