﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _911_RD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TransporSysEntities : DbContext
    {
        public TransporSysEntities()
            : base("name=TransporSysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ALMACENES> ALMACENES { get; set; }
        public virtual DbSet<ARTICULOS> ARTICULOS { get; set; }
        public virtual DbSet<BENEFICIOS> BENEFICIOS { get; set; }
        public virtual DbSet<CATEGORIAS> CATEGORIAS { get; set; }
        public virtual DbSet<CIUDADES> CIUDADES { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<COBROS> COBROS { get; set; }
        public virtual DbSet<COMPRAS> COMPRAS { get; set; }
        public virtual DbSet<CONTINENTES> CONTINENTES { get; set; }
        public virtual DbSet<COTIZACIONES> COTIZACIONES { get; set; }
        public virtual DbSet<CUOTAS> CUOTAS { get; set; }
        public virtual DbSet<DEPARTAMENTOS> DEPARTAMENTOS { get; set; }
        public virtual DbSet<DESCUENTOS> DESCUENTOS { get; set; }
        public virtual DbSet<DETALLES_COMPRAS> DETALLES_COMPRAS { get; set; }
        public virtual DbSet<DETALLES_COTIZACIONES> DETALLES_COTIZACIONES { get; set; }
        public virtual DbSet<DETALLES_ENTRADAS> DETALLES_ENTRADAS { get; set; }
        public virtual DbSet<DETALLES_SALIDAS> DETALLES_SALIDAS { get; set; }
        public virtual DbSet<DETALLES_VENTAS> DETALLES_VENTAS { get; set; }
        public virtual DbSet<DIRECCIONES> DIRECCIONES { get; set; }
        public virtual DbSet<EMAILS> EMAILS { get; set; }
        public virtual DbSet<EMPLEADOS> EMPLEADOS { get; set; }
        public virtual DbSet<ENTRADAS> ENTRADAS { get; set; }
        public virtual DbSet<EXISTENCIAS> EXISTENCIAS { get; set; }
        public virtual DbSet<FINANCIAMIENTOS> FINANCIAMIENTOS { get; set; }
        public virtual DbSet<IDENTIFICACIONES> IDENTIFICACIONES { get; set; }
        public virtual DbSet<ITEBIS> ITEBIS { get; set; }
        public virtual DbSet<MARCA> MARCA { get; set; }
        public virtual DbSet<MEMBRESIAS> MEMBRESIAS { get; set; }
        public virtual DbSet<MODELO> MODELO { get; set; }
        public virtual DbSet<NACIONALIDADES> NACIONALIDADES { get; set; }
        public virtual DbSet<NCF> NCF { get; set; }
        public virtual DbSet<PAISES> PAISES { get; set; }
        public virtual DbSet<PERSONAS> PERSONAS { get; set; }
        public virtual DbSet<PRECIOS> PRECIOS { get; set; }
        public virtual DbSet<PROVINCIAS> PROVINCIAS { get; set; }
        public virtual DbSet<PUESTOS> PUESTOS { get; set; }
        public virtual DbSet<SALIDAS> SALIDAS { get; set; }
        public virtual DbSet<SEXOS> SEXOS { get; set; }
        public virtual DbSet<SUPLIDORES> SUPLIDORES { get; set; }
        public virtual DbSet<TELEFONOS> TELEFONOS { get; set; }
        public virtual DbSet<TERCEROS> TERCEROS { get; set; }
        public virtual DbSet<TIPOS_CLIENTES> TIPOS_CLIENTES { get; set; }
        public virtual DbSet<TIPOS_IDENTIFICACIONES> TIPOS_IDENTIFICACIONES { get; set; }
        public virtual DbSet<TIPOS_MEMBRESIAS> TIPOS_MEMBRESIAS { get; set; }
        public virtual DbSet<TIPOS_SUPLIDORES> TIPOS_SUPLIDORES { get; set; }
        public virtual DbSet<TIPOS_TELEFONOS> TIPOS_TELEFONOS { get; set; }
        public virtual DbSet<TIPOS_USUARIOS> TIPOS_USUARIOS { get; set; }
        public virtual DbSet<TRANSPORTE> TRANSPORTE { get; set; }
        public virtual DbSet<UNIDADES_DE_MEDIDA> UNIDADES_DE_MEDIDA { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<VEHICULO> VEHICULO { get; set; }
        public virtual DbSet<VENTAS> VENTAS { get; set; }
        public virtual DbSet<ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS> ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS { get; set; }
        public virtual DbSet<TIPONCF> TIPONCF { get; set; }
    }
}