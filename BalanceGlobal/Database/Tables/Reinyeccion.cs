using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Reinyeccion
    {
        public int IdReinyeccion { get; set; }
        public int IdSistemasSubsitemas { get; set; }
        public int IdPeriodos { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? EvapAreaExpuestaM3dia { get; set; }
        public decimal? EvapAreaImpM3dia { get; set; }
        public decimal? SalmueraInfiltradaM3dia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
