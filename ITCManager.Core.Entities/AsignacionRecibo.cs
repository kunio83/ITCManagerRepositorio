//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITCManager.Core.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class AsignacionRecibo
    {
        public int IdAsignacionRecibo { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdRecibo { get; set; }
        public int IdRolEmpleado { get; set; }
    
        public virtual Recibo Recibo { get; set; }
        public virtual RolEmpleado RolEmpleado { get; set; }
    }
}
