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
    
    public partial class DetalleCondicionEmpleado
    {
        public int IdDetalleCondicionEmpleado { get; set; }
        public int IdRolEmpleado { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdCondicionEmpleado { get; set; }
    
        public virtual RolEmpleado RolEmpleado { get; set; }
    }
}