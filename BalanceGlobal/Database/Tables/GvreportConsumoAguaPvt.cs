using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvreportConsumoAguaPvt
    {
        public string Periodo { get; set; }
        public string SuperGrupoReporte { get; set; }
        public decimal? MopH2 { get; set; }
        public decimal? MophI { get; set; }
        public decimal? Otros { get; set; }
        public decimal? Pci { get; set; }
        public decimal? PorteoMop { get; set; }
        public decimal? PorteoSop { get; set; }
        public decimal? PozasHalitas { get; set; }
        public decimal? PozasHalitasSilvinitas { get; set; }
        public decimal? PozasLitioCarnalitas { get; set; }
        public decimal? PozasSop { get; set; }
        public decimal? Sop { get; set; }
        public decimal? Soph { get; set; }
        public decimal? TkAguaPP { get; set; }
    }
}
