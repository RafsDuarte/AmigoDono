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
    
    public partial class vw_PET
    {
        public byte[] Imagem { get; set; }
        public string NomePet { get; set; }
        public string TipoPet { get; set; }
        public string Situacao { get; set; }
        public string Idade { get; set; }
        public string NomeRaça { get; set; }
        public string Sexo { get; set; }
        public string Porte { get; set; }
        public string Castrado { get; set; }
        public Nullable<System.DateTime> DataNascimento { get; set; }
        public string OBS { get; set; }
        public System.DateTime Cadastro { get; set; }
        public int IDP { get; set; }
        public Nullable<int> IDRaça { get; set; }
    }
}
