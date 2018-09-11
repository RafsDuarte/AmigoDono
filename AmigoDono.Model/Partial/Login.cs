using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model
{
    public class Login
    {
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Senha")]
        [StringLength(20, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres", MinimumLength = 8)]
        public string Senha { get; set; }
    }
}
