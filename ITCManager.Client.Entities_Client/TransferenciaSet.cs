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
    
    public partial class TransferenciaSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransferenciaSet()
        {
            this.PagoLocalTransferenciaSet = new HashSet<PagoLocalTransferenciaSet>();
        }
    
        public long IdTransferencia { get; set; }
        public long IdCuentaBanco { get; set; }
        public long IdCuentaBancoTercero { get; set; }
        public string Monto { get; set; }
        public long IdEstadoTransferencia { get; set; }
        public string Observaciones { get; set; }
    
        public virtual CuentaBancoSet CuentaBancoSet { get; set; }
        public virtual CuentaBancoTerceroSet CuentaBancoTerceroSet { get; set; }
        public virtual EstadoTransferenciaSet EstadoTransferenciaSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoLocalTransferenciaSet> PagoLocalTransferenciaSet { get; set; }
    }
}
