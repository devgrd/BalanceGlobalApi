using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvRepInventarioAtacamaDelta
    {
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string TipoInventario { get; set; }
        public decimal? Ton { get; set; }
        public decimal? TonPrev { get; set; }
        public decimal? TonDelta { get; set; }
        public decimal? LceTon { get; set; }
        public decimal? LceTonDelta { get; set; }
        public decimal? KTonDelta { get; set; }
        public decimal? MgTonDelta { get; set; }
        public decimal? So4TonDelta { get; set; }
        public decimal? CaTonDelta { get; set; }
        public decimal? ClTonDelta { get; set; }
        public decimal? NaTonDelta { get; set; }
        public decimal? H3bo3TonDelta { get; set; }
    }
}
