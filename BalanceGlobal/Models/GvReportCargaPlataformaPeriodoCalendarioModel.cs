using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvReportCargaPlataformaPeriodoCalendarioModel : ModelBase
    {
        public string Periodo { get; set; }
        public string TipoSal { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? LceTon { get; set; }
        public decimal? KTon { get; set; }
        public decimal? MgTon { get; set; }
        public decimal? So4Ton { get; set; }
        public decimal? CaTon { get; set; }
        public decimal? ClTon { get; set; }
        public decimal? NaTon { get; set; }
        public decimal? H3bo3Ton { get; set; }
    }
}
