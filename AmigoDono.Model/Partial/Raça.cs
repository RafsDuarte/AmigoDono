using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AmigoDono.Model
{
    [MetadataType(typeof(MD_RAÇA))]
    public partial class RAÇA
    {
        internal class MD_RAÇA
        {

            [DisplayName("ID")]
            public object IDR { get; set; }
            [DisplayName("Raça")]
            public object NomeRaça { get; set; }
          
        }
    }
}
