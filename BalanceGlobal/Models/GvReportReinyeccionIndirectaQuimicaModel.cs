using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvReportReinyeccionIndirectaQuimicaModel : ModelBase
    {
        public DateTime? FechaGrupo { get; set; }
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? FlujoPulpaM3 { get; set; }
        public decimal? DensidadPulpa { get; set; }
        public decimal? MasaPulpaTon { get; set; }
        public decimal? SalmueraPulpaTon { get; set; }
        public decimal? DensSalmGml { get; set; }
        public decimal? MasaSalPulpaTon { get; set; }
        public decimal? KSalmueraTon { get; set; }
        public decimal? NaSalmTon { get; set; }
        public decimal? MgSalmTon { get; set; }
        public decimal? CaSalmTon { get; set; }
        public decimal? So4SalmTon { get; set; }
        public decimal? LiSalmTon { get; set; }
        public decimal? ClSalmTon { get; set; }
        public decimal? H3bo3Ton { get; set; }
        public decimal? KSolTon { get; set; }
        public decimal? NaSolTon { get; set; }
        public decimal? MgSolTon { get; set; }
        public decimal? CaSolTon { get; set; }
        public decimal? So4SolTon { get; set; }
        public decimal? LiSolTon { get; set; }
        public decimal? ClSolTon { get; set; }
        public decimal? H2o170gcSolTon { get; set; }
        public decimal? H3bo3SolTon { get; set; }
        public decimal? TkLimsSolPct { get; set; }
        public decimal? KSalmPct { get; set; }
        public decimal? NaSalmPct { get; set; }
        public decimal? MgSalmPct { get; set; }
        public decimal? CaSalmPct { get; set; }
        public decimal? So4SalmPct { get; set; }
        public decimal? LiSalmPct { get; set; }
        public decimal? ClSalmPct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public decimal? KSolPct { get; set; }
        public decimal? NaSolPct { get; set; }
        public decimal? MgSolPct { get; set; }
        public decimal? CaSolPct { get; set; }
        public decimal? So4SolPct { get; set; }
        public decimal? LiSolPct { get; set; }
        public decimal? ClSolPct { get; set; }
        public decimal? H2o170gcSolPct { get; set; }
        public decimal? H3bo3SolPct { get; set; }
        public decimal? TkSiproSolPct { get; set; }
        public decimal? FlujoRepulpeo { get; set; }
    }
}
