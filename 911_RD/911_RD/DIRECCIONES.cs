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
    
    public partial class DIRECCIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIRECCIONES()
        {
            this.TERCEROS_VS_DIRECCIONES = new HashSet<TERCEROS_VS_DIRECCIONES>();
        }
    
        public int id_direccion { get; set; }
        public decimal latitud { get; set; }
        public decimal longitud { get; set; }
    
        public virtual CIUDADES CIUDADES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TERCEROS_VS_DIRECCIONES> TERCEROS_VS_DIRECCIONES { get; set; }
    }
}
