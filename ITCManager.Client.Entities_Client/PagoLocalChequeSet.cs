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
    
    public partial class PagoLocalChequeSet
    {
        public long IdPagoLocalCheque { get; set; }
        public long IdPagoLocal { get; set; }
        public long IdCheque { get; set; }
    
        public virtual ChequeSet ChequeSet { get; set; }
        public virtual PagoLocalSet PagoLocalSet { get; set; }
    }
}
