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
    
    public partial class RolVendedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RolVendedor()
        {
            this.PlanVendedorAlumnoSet = new HashSet<PlanVendedorAlumnoSet>();
        }
    
        public long IdRolVendedor { get; set; }
        public long IdRolEmpleado { get; set; }
        public long IdSubgerente { get; set; }
        public long IdGerente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanVendedorAlumnoSet> PlanVendedorAlumnoSet { get; set; }
        public virtual RolEmpleado RolEmpleado { get; set; }
    }
}
