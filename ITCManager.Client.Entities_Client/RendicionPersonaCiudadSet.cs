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
    
    public partial class RendicionPersonaCiudadSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RendicionPersonaCiudadSet()
        {
            this.RendicionDepositoSet = new HashSet<RendicionDepositoSet>();
            this.RendicionGastoSet = new HashSet<RendicionGastoSet>();
            this.RendicionPagoSet = new HashSet<RendicionPagoSet>();
            this.RendicionSueldoSet = new HashSet<RendicionSueldoSet>();
            this.RendicionValeSet = new HashSet<RendicionValeSet>();
        }
    
        public long IdRendicionEmpleadoCiudad { get; set; }
        public long IdRolEmpleado { get; set; }
        public long IdRolCiudadActiva { get; set; }
        public long IdEstadoRendicion { get; set; }
    
        public virtual EstadoRendicionSet EstadoRendicionSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RendicionDepositoSet> RendicionDepositoSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RendicionGastoSet> RendicionGastoSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RendicionPagoSet> RendicionPagoSet { get; set; }
        public virtual RolEmpleado RolEmpleado { get; set; }
        public virtual RolCiudadActivaSet RolCiudadActivaSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RendicionSueldoSet> RendicionSueldoSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RendicionValeSet> RendicionValeSet { get; set; }
    }
}
