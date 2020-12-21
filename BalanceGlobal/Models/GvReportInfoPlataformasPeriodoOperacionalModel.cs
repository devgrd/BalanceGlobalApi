using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvReportInfoPlataformasPeriodoOperacionalModel : ModelBase
    {
        public string PeriodoOperacional { get; set; }
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
