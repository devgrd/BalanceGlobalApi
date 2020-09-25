using System.ComponentModel.DataAnnotations;
using System;

namespace BalanceGlobal.Models
{
    public class OperaPozasModel : ModelBase
    {
        [Required] public int IdOperaPozas { get; set; }
        [Required] public int IdSistemas { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public DateTime Fecha { get; set; }
        [Required] public int IdInfraestructuraOrigen { get; set; }
        [Required] public int IdInfraestructuraDestino { get; set; }
        public decimal? VolumenInicialM3 { get; set; }
        public decimal? VolumenFinalM3 { get; set; }
        public decimal? VolumenTraspasoM3 { get; set; }
        public decimal? Horometro { get; set; }
        public decimal? CaudalInstantaneoM3s { get; set; }
        public decimal? BPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? KPct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? SatK { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public decimal? DensidadTonm3 { get; set; }
    }
}
