using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace AmigoDono.Model
{
    [MetadataType(typeof(MD_TRATAMENTO))]
    public partial class TRATAMENTO
    {
        internal class MD_TRATAMENTO
        {
            [DisplayName("ID")]
            public object IDT { get; set; }
            [DisplayName("Tipo")]
            public object Tipo { get; set; }
            [DisplayName("IDPet")]
            public object IDPet { get; set; }
            [DisplayName("Data")]
            public DateTime DataTratamento { get; set; }
            [DisplayName("Observação")]
            public object OBS { get; set; }
            [DisplayName("Descricao")]
            public object IDDescricao { get; set; }
            [DisplayName("Responsavel")]
            public object IDResponsavel { get; set; }
        }
    }
}
