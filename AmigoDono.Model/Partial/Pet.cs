using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AmigoDono.Model
{
    [MetadataType(typeof(MD_PET))]
    public partial class PET
    {
        internal class MD_PET
        {
            [DisplayName("ID")]
            public object IDP { get; set; }
            [DisplayName("Nome do Pet")]
            public object NomePet { get; set; }
            [DisplayName("Tipo")]
            public object TipoPet { get; set; }
            [DisplayName("Idade")]
            public object Idade { get; set; }
            [DisplayName("Raça")]
            public object Raca { get; set; }
            [DisplayName("Sexo")]
            public object Sexo { get; set; }
            [DisplayName("Porte")]
            public object Porte { get; set; }
            [DisplayName("Cadastro")]
            public DateTime Cadastro { get; set; }
            [DisplayName("Data de nascimento")]
            public DateTime DataNascimento { get; set; }
            [DisplayName("Observação")]
            public object OBS { get; set; }
            [DisplayName("Imagem")]
            public object Imagem { get; set; }
            [DisplayName("Situacao")]
            public object Situacao { get; set; }
        }
    }
}
