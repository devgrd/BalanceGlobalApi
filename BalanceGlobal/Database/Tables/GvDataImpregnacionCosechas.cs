using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataImpregnacionCosechas
    {
        public int IdImpregnacionCosechas { get; set; }
        public string Periodo { get; set; }
        public string Infraestructura { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public decimal? CosechaTon { get; set; }
        public decimal? CosechaM3 { get; set; }
        public decimal? HumedadPct { get; set; }
        public decimal? KPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public int Prioridad { get; set; }
        public decimal? ImpregnacionPct { get; set; }
        public decimal? ImprgTon { get; set; }
        public decimal? LceTon { get; set; }
        public decimal? LiTon { get; set; }
        public decimal? KTon { get; set; }
        public decimal? MgTon { get; set; }
        public decimal? So4Ton { get; set; }
        public decimal? CaTon { get; set; }
        public decimal? ClTon { get; set; }
        public decimal? NaTon { get; set; }
        public decimal? H3bo3Ton { get; set; }
    }
}
