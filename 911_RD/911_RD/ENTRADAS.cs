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
    
    public partial class ENTRADAS
    {
        public int num_entrada { get; set; }
        public int id_suplidor { get; set; }
        public int id_empleado { get; set; }
        public System.DateTime fecha { get; set; }
        public string nota { get; set; }
        public bool estado { get; set; }
    
        public virtual DETALLES_ENTRADAS DETALLES_ENTRADAS { get; set; }
        public virtual EMPLEADOS EMPLEADOS { get; set; }
        public virtual SUPLIDORES SUPLIDORES { get; set; }
    }
}
