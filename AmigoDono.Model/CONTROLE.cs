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
    
    public partial class CONTROLE
    {
        public int IDC { get; set; }
        public int IDPet { get; set; }
        public int IDDono { get; set; }
        public int IDDoador { get; set; }
        public Nullable<System.DateTime> DataAdocao { get; set; }
        public string Statu { get; set; }
        public string OBS { get; set; }
    
        public virtual AMIGO AMIGO { get; set; }
        public virtual AMIGO AMIGO1 { get; set; }
        public virtual PET PET { get; set; }
    }
}
