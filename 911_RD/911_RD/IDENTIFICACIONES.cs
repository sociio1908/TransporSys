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
    
    public partial class IDENTIFICACIONES
    {
        public int id_identificacion { get; set; }
        public int id_tipo_identificacion { get; set; }
        public string identificacion { get; set; }
    
        public virtual TIPOS_IDENTIFICACIONES TIPOS_IDENTIFICACIONES { get; set; }
    }
}
