//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITCManager.Core.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleArmadoEquipo
    {
        public int IdDetalleArmadoEquipo { get; set; }
        public int IdArmadoEquipo { get; set; }
        public int IdProducto { get; set; }
    
        public virtual ArmadoEquipo ArmadoEquipo { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
