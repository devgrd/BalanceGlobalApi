using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvreportFlujos
    {
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Flujo { get; set; }
        public decimal? FlujoDifM3 { get; set; }
    }
}
