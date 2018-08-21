using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmigoDono.Model
{
    [MetadataType(typeof(MD_AMIGO))]
    public partial class AMIGO
    {
        

        internal class MD_AMIGO
        {

            [DisplayName("ID")]
            public object IDA { get; set; }

            [DisplayName("Data Cadastro")]
            public DateTime DataCadastro { get; set; }

            [DisplayName("Função")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(50, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object Funcao { get; set; }

            [DisplayName("Senha")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(20, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object Senha { get; set; }

            [DisplayName("Ajuda")]
            public object Ajuda { get; set; }

            [DisplayName("Data Nascimento")]
            public DateTime DataNascimento { get; set; }

            [DisplayName("CPF")]
            public object CPF { get; set; }

            [DisplayName("CNPJ")]
            public object CNPJ { get; set; }

            [DisplayName("Nome")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object Nome { get; set; }

            [DisplayName("Email")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [DataType(DataType.EmailAddress)]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            [Index("EmailIndex", IsUnique = true)]
            public object Email { get; set; }

            [DisplayName("CEP")]
            public object CEP { get; set; }

            [DisplayName("Logradouro")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object Logradouro { get; set; }

            [DisplayName("Nome do Logradouro ")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object NomeLogradouro { get; set; }

            [DisplayName("Numero")]
            public object Numero { get; set; }

            [DisplayName("Complemento")]
            public object Complemento { get; set; }
            
            [DisplayName("Bairro")]
            public object Bairro { get; set; }

            [DisplayName("Cidade")]
            public object Cidade { get; set; }

            [DisplayName("UF")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(2, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object UF { get; set; }

            [DisplayName("Telefone")]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object Telefone { get; set; }

            [DisplayName("Celular")]
            public object Celular { get; set; }

            [DisplayName("Imagem")]
            [DataType(DataType.ImageUrl)]
            public byte[] Imagem { get; set; }

        }
    }
}
