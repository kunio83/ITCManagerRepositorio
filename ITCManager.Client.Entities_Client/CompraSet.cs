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
    
    public partial class CompraSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompraSet()
        {
            this.DetalleCompraSet = new HashSet<DetalleCompraSet>();
        }
    
        public long IdCompra { get; set; }
        public string Fecha { get; set; }
        public long IdProveedor { get; set; }
        public long IdEstadoCompra { get; set; }
        public long IdPagoLocal { get; set; }
    
        public virtual ProveedorSet ProveedorSet { get; set; }
        public virtual PagoLocalSet PagoLocalSet { get; set; }
        public virtual EstadoCompraSet EstadoCompraSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCompraSet> DetalleCompraSet { get; set; }
    }
}
