//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmigoDono.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_TRATAMENTO
    {
        public int IDT { get; set; }
        public int IDResponsavel { get; set; }
        public string Nome { get; set; }
        public int IDPet { get; set; }
        public string PET { get; set; }
        public string Tipo { get; set; }
        public System.DateTime DataTratamento { get; set; }
        public string OBS { get; set; }
        public int IDDescricao { get; set; }
        public string Descricao { get; set; }
    }
}
