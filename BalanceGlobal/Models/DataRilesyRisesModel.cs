using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataRilesyRisesModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string Corriente { get; set; }
        public string Sistema { get; set; }
        public double? MasaTon { get; set; }
        public double? KPct { get; set; }
        public double? NaPct { get; set; }
        public double? MgPct { get; set; }
        public double? CaPct { get; set; }
        public double? So4Pct { get; set; }
        public double? LiPct { get; set; }
        public double? ClPct { get; set; }
        public double? H3bo3Pct { get; set; }
    }
}
