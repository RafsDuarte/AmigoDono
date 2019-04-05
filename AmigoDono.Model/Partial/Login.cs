using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AmigoDono.Model
{
    public class Login
    {
        [DisplayName("Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }
        
        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Digite uma senha com pelo menos 8 caracteres")]
        public string Senha { get; set; }
    }
}
