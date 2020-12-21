using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvdataConsLitioLiCo3mensual
    {
        public int IdConsLitioLiCo3mensual { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string Periodo { get; set; }
        public string CorrienteLi2Co3 { get; set; }
        public decimal? Li2Co3FrescaTon { get; set; }
        public decimal? Li2Co3TotalTon { get; set; }
        public decimal? CarbonatoTon { get; set; }
        public decimal? LitioFrescoTon { get; set; }
    }
}
