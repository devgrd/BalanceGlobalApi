using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvreporteEvaporacionPeriodoCalendario
    {
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string SubSistema { get; set; }
        public decimal? Evaporacion { get; set; }
    }
}
