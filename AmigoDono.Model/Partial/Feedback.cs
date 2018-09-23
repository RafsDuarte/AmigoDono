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

            [DisplayName("Nome")]
            public object Nome { get; set; }
            [DisplayName("Email")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [DataType(DataType.EmailAddress)]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object Email { get; set; }

            [DisplayName("Opinião")]
            public object Opiniao { get; set; }
            [DisplayName("Feedback")]
            public object Feedback { get; set; }

        }
    }
}
