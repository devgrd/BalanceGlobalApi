using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataSolicionLitioConsLi2Co3Model : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string CorrienteGlobal { get; set; }
        public string CorrienteLi2Co3 { get; set; }
        public double? VolM3 { get; set; }
        public double? DensTonm3 { get; set; }
        public double? MasaTon { get; set; }
        public double? KPct { get; set; }
        public double? NaPct { get; set; }
        public double? MgPct { get; set; }
        public double? CaPct { get; set; }
        public double? So4Pct { get; set; }
        public double? LiPct { get; set; }
        public double? ClPct { get; set; }
        public double? BPct { get; set; }
    }
}
