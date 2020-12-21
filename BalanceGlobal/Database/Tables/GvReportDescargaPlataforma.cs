using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvReportDescargaPlataforma
    {
        public int IdDescargaPlataformas { get; set; }
        public DateTime Fecha { get; set; }
        public string Periodo { get; set; }
        public string PeriodoOperacional { get; set; }
        public string Plataforma { get; set; }
        public string Destinos { get; set; }
        public decimal? VolSalidaM3 { get; set; }
        public decimal? ImpregnacionPct { get; set; }
        public decimal? VolenPlataformaM3 { get; set; }
        public string TipoSal { get; set; }
        public decimal? VolumenM3 { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? KPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? H3b3oPct { get; set; }
        public decimal? LceTon { get; set; }
        public decimal? KTon { get; set; }
        public decimal? MgTon { get; set; }
        public decimal? So4Ton { get; set; }
        public decimal? CaTon { get; set; }
        public decimal? ClTon { get; set; }
        public decimal? NaTon { get; set; }
        public decimal? H3b3oTon { get; set; }
    }
}
