//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ARTICULOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTICULOS()
        {
            this.ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS = new HashSet<ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS>();
            this.DETALLES_VENTAS = new HashSet<DETALLES_VENTAS>();
            this.DETALLES_COMPRAS = new HashSet<DETALLES_COMPRAS>();
            this.DETALLES_COTIZACIONES = new HashSet<DETALLES_COTIZACIONES>();
            this.DETALLES_ENTRADAS = new HashSet<DETALLES_ENTRADAS>();
            this.DETALLES_SALIDAS = new HashSet<DETALLES_SALIDAS>();
            this.EXISTENCIAS = new HashSet<EXISTENCIAS>();
            this.FINANCIAMIENTOS = new HashSet<FINANCIAMIENTOS>();
            this.PRECIOS = new HashSet<PRECIOS>();
        }
    
        public int id_articulo { get; set; }
        public int id_categoria { get; set; }
        public int id_unidad_de_medida { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int reorden { get; set; }
        public string codigo_barras { get; set; }
        public double precio { get; set; }
        public bool estado { get; set; }
    
        public virtual CATEGORIAS CATEGORIAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS> ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLES_VENTAS> DETALLES_VENTAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLES_COMPRAS> DETALLES_COMPRAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLES_COTIZACIONES> DETALLES_COTIZACIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLES_ENTRADAS> DETALLES_ENTRADAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLES_SALIDAS> DETALLES_SALIDAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXISTENCIAS> EXISTENCIAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FINANCIAMIENTOS> FINANCIAMIENTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRECIOS> PRECIOS { get; set; }
    }
}
