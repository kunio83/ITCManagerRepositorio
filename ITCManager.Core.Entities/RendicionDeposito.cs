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
    
    public partial class RendicionDeposito
    {
        public int IdRendicionDeposito { get; set; }
        public int IdRendicionPersonaCiudad { get; set; }
        public int IdDeposito { get; set; }
    
        public virtual RendicionPersonaCiudad RendicionPersonaCiudad { get; set; }
        public virtual Deposito Deposito { get; set; }
    }
}
