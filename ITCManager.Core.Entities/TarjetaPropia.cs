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
    
    public partial class TarjetaPropia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TarjetaPropia()
        {
            this.CompraTarjeta = new HashSet<PagoLocalTarjeta>();
        }
    
        public int IdTarjetaPropia { get; set; }
        public string Emsior { get; set; }
        public string NroTarjeta { get; set; }
        public string FechaVto { get; set; }
        public string CodSeguridad { get; set; }
        public string Titular { get; set; }
        public string DNI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoLocalTarjeta> CompraTarjeta { get; set; }
    }
}
