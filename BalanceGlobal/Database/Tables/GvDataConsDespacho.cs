using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataConsDespacho
    {
        public int IdConsDespacho { get; set; }
        public string Periodo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? MasaDespachadaTon { get; set; }
        public decimal? DensTonm3 { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? KPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? BPct { get; set; }
    }
}
