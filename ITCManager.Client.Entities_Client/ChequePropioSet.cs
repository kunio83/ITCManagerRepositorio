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
    
    public partial class ChequePropioSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChequePropioSet()
        {
            this.PagoLocalChequePropioSet = new HashSet<PagoLocalChequePropioSet>();
        }
    
        public long IdChequePropio { get; set; }
        public string NroCheque { get; set; }
        public string FechaEmision { get; set; }
        public string FechaPago { get; set; }
        public string Monto { get; set; }
        public string Destinatario { get; set; }
        public long IdEstadoCheque { get; set; }
        public long IdCuentaBanco { get; set; }
    
        public virtual CuentaBancoSet CuentaBancoSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoLocalChequePropioSet> PagoLocalChequePropioSet { get; set; }
    }
}
