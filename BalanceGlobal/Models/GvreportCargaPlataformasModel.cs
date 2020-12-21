using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvreportCargaPlataformasModel : ModelBase
    {
        [Required] public int IdCargaPlataformas { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public string Periodo { get; set; }
        public string PeriodoOperacional { get; set; }
        public string InfraestructuraOrigen { get; set; }
        public string Plataforma { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? ImpregnacionPct { get; set; }
        public string TipoSal { get; set; }
        public decimal? LiPct { get; set; }
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
        public decimal? H3bo3Ton { get; set; }
    }
}
