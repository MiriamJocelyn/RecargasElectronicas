﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ElHilvanEntities : DbContext
    {
        public ElHilvanEntities()
            : base("name=ElHilvanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Nota> Nota { get; set; }
        public DbSet<NotaPrenda> NotaPrenda { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Prenda> Prenda { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TipoArreglo> TipoArreglo { get; set; }
        public DbSet<TipoPrenda> TipoPrenda { get; set; }
    }
}
