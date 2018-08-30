using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AmigoDono.Model
{
    [MetadataType(typeof(MD_FEEDBACK))]
    public partial class FEEDBACK
    {
        internal class MD_FEEDBACK
        {

            [DisplayName("ID")]
            public object IDF { get; set; }

            [DisplayName("Data Cadastro")]
            public DateTime DataCadastro { get; set; }

            [DisplayName("Nome")]
            public object Nome { get; set; }
            [DisplayName("Email")]
            public object Email { get; set; }


            [DisplayName("Opnião")]
            public object Opniao { get; set; }
            [DisplayName("Feedback")]
            public object Feedback { get; set; }

        }
    }
}
