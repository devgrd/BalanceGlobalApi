using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvReinyeccion
    {
        public int IdReinyeccion { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string Periodo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? EvapAreaExpuestaM3dia { get; set; }
        public decimal? EvapAreaImpM3dia { get; set; }
        public decimal? SalmueraInfiltradaM3dia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
