//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITCManager.Client.Entities_Client
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleCondicionEmpleado
    {
        public long IdRolEmpleadoCondicion { get; set; }
        public long IdRolEmpleado { get; set; }
        public System.DateTime Fecha { get; set; }
        public long IdCondicionEmpleado { get; set; }
        public string MontoCondicion { get; set; }
    
        public virtual CondicionEmpleadoSet CondicionEmpleadoSet { get; set; }
        public virtual RolEmpleado RolEmpleado { get; set; }
    }
}
