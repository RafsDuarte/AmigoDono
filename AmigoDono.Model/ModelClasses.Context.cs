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
    
    public partial class Amigos_do_DonoEntities : DbContext
    {
        public Amigos_do_DonoEntities()
            : base("name=Amigos_do_DonoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AMIGO> AMIGO { get; set; }
        public virtual DbSet<CONTADOR> CONTADOR { get; set; }
        public virtual DbSet<CONTROLE> CONTROLE { get; set; }
        public virtual DbSet<DENUNCIA> DENUNCIA { get; set; }
        public virtual DbSet<FEEDBACK> FEEDBACK { get; set; }
        public virtual DbSet<PET> PET { get; set; }
        public virtual DbSet<RAÇA> RAÇA { get; set; }
        public virtual DbSet<TIPOTRATAMENTO> TIPOTRATAMENTO { get; set; }
        public virtual DbSet<TRATAMENTO> TRATAMENTO { get; set; }
        public virtual DbSet<vw_CONTROLE> vw_CONTROLE { get; set; }
        public virtual DbSet<vw_DENUNCIA> vw_DENUNCIA { get; set; }
        public virtual DbSet<vw_PET> vw_PET { get; set; }
        public virtual DbSet<vw_TRATAMENTO> vw_TRATAMENTO { get; set; }
    }
}
