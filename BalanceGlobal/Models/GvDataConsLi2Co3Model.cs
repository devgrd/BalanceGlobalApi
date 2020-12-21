using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataConsLi2Co3Model : ModelBase
    {
        [Required] public int IdConsLi2Co3 { get; set; }
        public string Periodo { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public string CorrienteGlobal { get; set; }
        public string CorrienteLi2Co3 { get; set; }
        public decimal? VolM3 { get; set; }
        public decimal? DensTonm3 { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? KPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? BPct { get; set; }
    }
}
