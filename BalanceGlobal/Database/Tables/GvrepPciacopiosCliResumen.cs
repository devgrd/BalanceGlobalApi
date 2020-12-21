using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvrepPciacopiosCliResumen
    {
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public decimal MasaTon { get; set; }
        public decimal? LiPct { get; set; }
        public decimal LceTon { get; set; }
    }
}
