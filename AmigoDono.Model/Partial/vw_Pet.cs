using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model
{
    [MetadataType(typeof(MD_vw_PET))]
    public partial class vw_PET
    {
        internal class MD_vw_PET
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
            public object NomeRaca { get; set; }
            [DisplayName("Sexo")]
            public object Sexo { get; set; }
            [DisplayName("Porte")]
            public object Porte { get; set; }
            [DisplayName("Cadastro")]
            public DateTime Cadastro { get; set; }
            [DisplayName("Data de nascimento")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
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