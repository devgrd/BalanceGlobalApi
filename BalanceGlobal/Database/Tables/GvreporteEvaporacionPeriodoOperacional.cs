using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvreporteEvaporacionPeriodoOperacional
    {
        public string PeriodoOperacional { get; set; }
        public string Sistema { get; set; }
        public string SubSistema { get; set; }
        public decimal? Evaporacion { get; set; }
    }
}
