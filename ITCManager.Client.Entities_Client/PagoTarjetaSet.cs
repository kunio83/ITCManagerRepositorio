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
    
    public partial class PagoTarjetaSet
    {
        public long IdPagoTarjeta { get; set; }
        public long IdPago { get; set; }
        public string MontoAPagar { get; set; }
        public long IdCuotas { get; set; }
        public string Recargo { get; set; }
        public string MontoTotal { get; set; }
        public string NumeroTarjeta { get; set; }
        public string EmisorTarjeta { get; set; }
        public string CodSeguridad { get; set; }
        public string Vencimiento { get; set; }
        public string TitularTarjeta { get; set; }
        public string DNI { get; set; }
        public string CodAut { get; set; }
        public long IdEstadoPagoTarjeta { get; set; }
    
        public virtual CoeficTarjetasSet CoeficTarjetasSet { get; set; }
        public virtual EstadoPagoTarjetaSet EstadoPagoTarjetaSet { get; set; }
        public virtual PagoSet PagoSet { get; set; }
    }
}
