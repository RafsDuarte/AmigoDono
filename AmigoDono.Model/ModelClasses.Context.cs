﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AmigoDonoEntities : DbContext
    {
        public AmigoDonoEntities()
            : base("name=AmigoDonoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AMIGO> AMIGO { get; set; }
        public virtual DbSet<CONTROLE> CONTROLE { get; set; }
        public virtual DbSet<DENUNCIA> DENUNCIA { get; set; }
        public virtual DbSet<PET> PET { get; set; }
        public virtual DbSet<TRATAMENTO> TRATAMENTO { get; set; }
    }
}
