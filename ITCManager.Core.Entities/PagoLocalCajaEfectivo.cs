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
    
    public partial class PagoLocalCajaEfectivo
    {
        public int IdPagoLocalCajaEfectivo { get; set; }
        public int IdPagoLocal { get; set; }
        public string FechaPagoCajaEfectivo { get; set; }
        public string Monto { get; set; }
        public int IdCajaEfectivo { get; set; }
    
        public virtual PagoLocal PagoLocal { get; set; }
        public virtual CajaEfectivo CajaEfectivo { get; set; }
    }
}