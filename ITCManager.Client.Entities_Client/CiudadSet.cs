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
    
    public partial class CiudadSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CiudadSet()
        {
            this.CiudadPersonalSet = new HashSet<CiudadPersonalSet>();
            this.RolCiudadActivaSet = new HashSet<RolCiudadActivaSet>();
            this.RolCiudadEnProcesoSet = new HashSet<RolCiudadEnProcesoSet>();
        }
    
        public long IdCiudad { get; set; }
        public string DesignacionCiudad { get; set; }
        public long IdLocalidad { get; set; }
        public string PeriodoApertura { get; set; }
        public string CantidadMeses { get; set; }
        public bool Activa { get; set; }
        public string NumeroLinea { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CiudadPersonalSet> CiudadPersonalSet { get; set; }
        public virtual LocalidadSet LocalidadSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolCiudadActivaSet> RolCiudadActivaSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolCiudadEnProcesoSet> RolCiudadEnProcesoSet { get; set; }
    }
}
