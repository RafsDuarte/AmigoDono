using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AmigoDono.Model;

namespace AmigoDono.Web.Models
{
    public class AmigoView
    {
        public AMIGO Amigo { get; set; }
        public HttpPostedFileBase Imagem { get; set; }
    }
}