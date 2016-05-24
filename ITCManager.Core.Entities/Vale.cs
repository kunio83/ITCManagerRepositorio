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
    
    public partial class Vale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vale()
        {
            this.RendicionVale = new HashSet<RendicionVale>();
            this.ValeFinanciacion = new HashSet<ValeFinanciacion>();
        }
    
        public int IdVale { get; set; }
        public string Fecha { get; set; }
        public int IdRolEmpleado { get; set; }
        public string Monto { get; set; }
        public string Observaciones { get; set; }
    
        public virtual RolEmpleado RolEmpleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RendicionVale> RendicionVale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValeFinanciacion> ValeFinanciacion { get; set; }
    }
}