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
    
    public partial class CIUDADES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CIUDADES()
        {
            this.DIRECCIONES = new HashSet<DIRECCIONES>();
        }
    
        public double id_ciudad { get; set; }
        public int id_provincia { get; set; }
        public string ciudad { get; set; }
    
        public virtual PROVINCIAS PROVINCIAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIRECCIONES> DIRECCIONES { get; set; }
    }
}
