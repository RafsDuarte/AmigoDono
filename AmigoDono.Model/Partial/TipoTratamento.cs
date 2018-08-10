using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AmigoDono.Model
{
    [MetadataType(typeof(MD_TIPOTRATAMENTO))]
    public partial class TIPOTRATAMENTO
    {
        internal class MD_TIPOTRATAMENTO
        {

            [DisplayName("ID")]
            public object IDTT { get; set; }
          
            [DisplayName("Descriçao")]
            public object Descricao { get; set; }
           
        }
    }
}
