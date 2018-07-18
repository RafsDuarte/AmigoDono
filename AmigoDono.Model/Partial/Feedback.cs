using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDono.Model
{
    [MetadataType(typeof(MD_FEEDBACK))]
    public partial class FEEDBACK
    {
        internal class MD_FEEDBACK
        {
            [DisplayName("ID")]
            public object IDF { get; set; }
            [DisplayName("Nome")]
            public object Nome { get; set; }
            [DisplayName("Email")]
            public object Email { get; set; }
            [DisplayName("Sua opinião")]
            public object Opiniao { get; set; }
            [DisplayName("Há algo que você gostaria de nos dizer?")]
            public object Feedback { get; set; }
        }
    }
}
