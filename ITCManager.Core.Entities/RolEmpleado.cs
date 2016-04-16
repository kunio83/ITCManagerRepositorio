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
    
    public partial class RolEmpleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RolEmpleado()
        {
            this.DetalleCondicionEmpleado = new HashSet<RolEmpleadoCondicion>();
            this.Permiso = new HashSet<Permiso>();
            this.CiudadPersonal = new HashSet<CiudadPersonal>();
            this.RolVendedor = new HashSet<RolVendedor>();
            this.RolVendedor1 = new HashSet<RolVendedor>();
            this.RolVendedor2 = new HashSet<RolVendedor>();
            this.AsignacionRecibo = new HashSet<AsignacionRecibo>();
            this.RendicionPersonaCiudad = new HashSet<RendicionPersonaCiudad>();
            this.RolDocente = new HashSet<RolDocente>();
        }
    
        public int IdRolEmpleado { get; set; }
        public int IdPersona { get; set; }
        public string IdPuesto { get; set; }
        public string CelCorp { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolEmpleadoCondicion> DetalleCondicionEmpleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permiso> Permiso { get; set; }
        public virtual Persona Persona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CiudadPersonal> CiudadPersonal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolVendedor> RolVendedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolVendedor> RolVendedor1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolVendedor> RolVendedor2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsignacionRecibo> AsignacionRecibo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RendicionPersonaCiudad> RendicionPersonaCiudad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolDocente> RolDocente { get; set; }
    }
}
