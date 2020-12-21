using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvReportInfiltracionModel : ModelBase
    {
        [Required] public int IdEvaporacionInfiltracion { get; set; }
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Infraestructura { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? AlturaSalmueraM { get; set; }
        public decimal? AreaM2 { get; set; }
        public decimal? KPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        public decimal? ClPct { get; set; }
        public string SistemaAtacama { get; set; }
        public string SubSistemaAtacama { get; set; }
        public decimal? Factor { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? PermeabilidadM3m2dia { get; set; }
    }
}
