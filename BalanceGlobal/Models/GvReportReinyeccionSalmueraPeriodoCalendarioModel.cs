using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvReportReinyeccionSalmueraPeriodoCalendarioModel : ModelBase
    {
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public decimal? SalmueraInfiltradaM3dia { get; set; }
        public decimal? DensidadSalmInfiltradaTonm3 { get; set; }
        public decimal? MasaFinalReinyeccionTondia { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? KPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? H3bo3Pct { get; set; }
    }
}
