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
    
    public partial class CONDUCTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONDUCTOR()
        {
            this.VIAJES = new HashSet<VIAJES>();
        }
    
        public int id_conductor { get; set; }
        public int id_empleado { get; set; }
        public int num_licencia { get; set; }
        public System.DateTime fecha_vencimiento { get; set; }
    
        public virtual EMPLEADOS EMPLEADOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIAJES> VIAJES { get; set; }
    }
}
