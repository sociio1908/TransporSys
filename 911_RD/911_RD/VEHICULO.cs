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
    
    public partial class VEHICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEHICULO()
        {
            this.GPS = new HashSet<GPS>();
        }
    
        public int id_vehiculo { get; set; }
        public int id_marca { get; set; }
        public int id_modelo { get; set; }
        public Nullable<int> id_conductor { get; set; }
        public string num_chasis { get; set; }
        public System.DateTime fecha_ingreso { get; set; }
        public System.DateTime ano_fabricacion { get; set; }
        public double gasto_galon_combustible_kilometro { get; set; }
        public int id_combustible { get; set; }
        public string num_gps { get; set; }
        public bool estado { get; set; }
    
        public virtual MARCA MARCA { get; set; }
        public virtual MODELO MODELO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GPS> GPS { get; set; }
    }
}
