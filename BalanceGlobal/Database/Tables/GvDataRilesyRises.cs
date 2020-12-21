using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataRilesyRises
    {
        public int IdConsRilesyRises { get; set; }
        public string Periodo { get; set; }
        public DateTime Fecha { get; set; }
        public string CorrientesRilesyRises { get; set; }
        public string Sistema { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? KPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? H3bo3Pct { get; set; }
    }
}
