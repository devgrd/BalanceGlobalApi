using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvReportInfoPlataformas
    {
        public string Periodo { get; set; }
        public string PeriodoOperacional { get; set; }
        public DateTime Fecha { get; set; }
        public string Plataforma { get; set; }
        public string PlataformaPadre { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? LceTon { get; set; }
        public decimal? MgTon { get; set; }
        public decimal? KTon { get; set; }
        public decimal? NaTon { get; set; }
        public decimal? CaTon { get; set; }
        public decimal? So4Ton { get; set; }
        public decimal? ClTon { get; set; }
        public decimal? H3bo3Ton { get; set; }
    }
}
