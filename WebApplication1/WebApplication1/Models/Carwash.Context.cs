﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CARWASHEntities1 : DbContext
    {
        public CARWASHEntities1()
            : base("name=CARWASHEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_AUTO> C_AUTO { get; set; }
        public virtual DbSet<C_LOGIN> C_LOGIN { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<COMPROBANTE_PAGO> COMPROBANTE_PAGO { get; set; }
        public virtual DbSet<EMPLEADO> EMPLEADO { get; set; }
        public virtual DbSet<MARCA_MATERIAL> MARCA_MATERIAL { get; set; }
        public virtual DbSet<MATERIALES> MATERIALES { get; set; }
        public virtual DbSet<ORDEN_ATENCION> ORDEN_ATENCION { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<SERVICIO> SERVICIO { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TIPO_COMPROBANTE> TIPO_COMPROBANTE { get; set; }
        public virtual DbSet<TIPO_EMPLEADO> TIPO_EMPLEADO { get; set; }
        public virtual DbSet<TIPO_LOGIN> TIPO_LOGIN { get; set; }
        public virtual DbSet<TIPO_SERVICIO> TIPO_SERVICIO { get; set; }
        public virtual DbSet<VENTAS_DIARIAS> VENTAS_DIARIAS { get; set; }
        public virtual DbSet<DETALLE_ORDEN_ATENCION> DETALLE_ORDEN_ATENCION { get; set; }
        public virtual DbSet<ORDEN_COMPRA> ORDEN_COMPRA { get; set; }
        public virtual DbSet<REGISTRAR_SERVICIO> REGISTRAR_SERVICIO { get; set; }
    }
}