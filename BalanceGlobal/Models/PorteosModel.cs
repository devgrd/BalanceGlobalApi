using System.ComponentModel.DataAnnotations;
using System;

namespace BalanceGlobal.Models
{
    public class PorteosModel : ModelBase
    {
        [Required] public int IdPorteos { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdSistemasSubsistemas { get; set; }
        [Required] public DateTime FechaHora { get; set; }
        public decimal? KSalmPct { get; set; }
        public decimal? NaSalmPct { get; set; }
        public decimal? MgSalmPct { get; set; }
        public decimal? CaSalmPct { get; set; }
        public decimal? So4SalmPct { get; set; }
        public decimal? LiSalmPct { get; set; }
        public decimal? ClSalmPct { get; set; }
        public decimal? DensSalmGml { get; set; }
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
        public decimal? TkLimsSolPct { get; set; }
        public decimal? TkSiproSolPct { get; set; }
        public decimal? FlujoRepulpeo { get; set; }

    }
}