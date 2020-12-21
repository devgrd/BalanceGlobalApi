using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataFlujos
    {
        public int IdFlujos { get; set; }
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string Bomba { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? TotalizadorM3 { get; set; }
    }
}
