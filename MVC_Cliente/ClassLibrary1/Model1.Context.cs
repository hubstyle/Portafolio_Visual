﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CARGO_EXTRA> CARGO_EXTRA { get; set; }
        public DbSet<CHECKLIST> CHECKLIST { get; set; }
        public DbSet<CONTRATO_ESTADOS> CONTRATO_ESTADOS { get; set; }
        public DbSet<CONTRATOS> CONTRATOS { get; set; }
        public DbSet<EMPRESAS> EMPRESAS { get; set; }
        public DbSet<FORMA_PAGO> FORMA_PAGO { get; set; }
        public DbSet<PAGOS> PAGOS { get; set; }
        public DbSet<REPORTES> REPORTES { get; set; }
        public DbSet<ROLES> ROLES { get; set; }
        public DbSet<SERVICIO_TIPOS> SERVICIO_TIPOS { get; set; }
        public DbSet<SERVICIOS> SERVICIOS { get; set; }
        public DbSet<SERVICIOS_ESTADO> SERVICIOS_ESTADO { get; set; }
        public DbSet<TIPO_REPORTE> TIPO_REPORTE { get; set; }
        public DbSet<USUARIOS> USUARIOS { get; set; }
    }
}