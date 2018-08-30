using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model
{
    public class LOGIN
    {

            [DisplayName("Email")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
        public string Email { get; set; }

            [DisplayName("Senha")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(20, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            [DataType(DataType.Password)]
            public string Senha { get; set; }
    }
}
