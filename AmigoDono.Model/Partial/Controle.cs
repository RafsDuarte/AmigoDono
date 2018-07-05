using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AmigoDono.Model
{
    [MetadataType(typeof(MD_CONTROLE))]
    public partial class CONTROLE
    {
        internal class MD_CONTROLE
        {
            [DisplayName("ID")]
            public object IDC { get; set; }
            [DisplayName("Id do Pet")]
            public object IDPet { get; set; }
            [DisplayName("Id do Amigo")]
            public object IDAmigo { get; set; }
            [DisplayName("Data da Adocao")]
            public object DataAdocao { get; set; }
            [DisplayName("Status")]
            public object Status { get; set; }
            [DisplayName("Observação")]
            public object OBS { get; set; }
        }
    }
}
