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
    
    public partial class EXISTENCIAS
    {
        public int id_articulo { get; set; }
        public int id_unidad_de_medida { get; set; }
        public int id_almacen { get; set; }
        public int cantidad { get; set; }
    
        public virtual ALMACENES ALMACENES { get; set; }
        public virtual ARTICULOS ARTICULOS { get; set; }
        public virtual UNIDADES_DE_MEDIDA UNIDADES_DE_MEDIDA { get; set; }
    }
}