//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class RolVendedor
    {
        public int IdRolVendedor { get; set; }
        public int IdPersona { get; set; }
        public int IdSubgerente { get; set; }
        public int IdGerente { get; set; }
        public string CelCorp { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual Persona Persona1 { get; set; }
        public virtual Persona Persona2 { get; set; }
    }
}
