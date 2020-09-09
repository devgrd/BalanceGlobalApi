using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Cosechas
    {
        public int IdCosechas { get; set; }
        public int IdPeriodos { get; set; }
        public int IdSistemasSubSistemas { get; set; }
        public int IdInfraestructuras { get; set; }
        public decimal? AlturaPozaM { get; set; }
        public decimal? CosechaTon { get; set; }
        public decimal? CosechaM3 { get; set; }
        public decimal? Densidad { get; set; }
        public decimal? KPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public decimal? ImprgPct { get; set; }
        public decimal? HumPct { get; set; }
    }
}
