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
    
    public partial class RolAlumnoPracticasSet
    {
        public long IdRolAlumnoPracticas { get; set; }
        public long IdCiudadFechasHorarios { get; set; }
        public string TipoPractica { get; set; }
        public string EstadoPractica { get; set; }
        public long IdRolAlumno { get; set; }
    
        public virtual CiudadFechasHorariosSet CiudadFechasHorariosSet { get; set; }
        public virtual RolAlumno RolAlumno { get; set; }
    }
}
