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
    
    public partial class RolCiudadActivaHorarioSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RolCiudadActivaHorarioSet()
        {
            this.AlumnoHorarioSet = new HashSet<AlumnoHorarioSet>();
        }
    
        public long IdRolCiudadActivaHorario { get; set; }
        public long IdDia { get; set; }
        public long IdHorario { get; set; }
        public long IdRolCiudadActiva { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoHorarioSet> AlumnoHorarioSet { get; set; }
        public virtual DiaSet DiaSet { get; set; }
        public virtual HorarioSet HorarioSet { get; set; }
        public virtual RolCiudadActivaSet RolCiudadActivaSet { get; set; }
    }
}
