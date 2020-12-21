using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataExtraccionSalmueraModel : ModelBase
    {
        [Required] public int IdExtraccion { get; set; }
        public string Periodo { get; set; }
        public string PeriodoOperacional { get; set; }
        public string Sistema { get; set; }
        public string SubSistema { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public string InfraestructuraOrigen { get; set; }
        public string InfraestructuraDestino { get; set; }
        public decimal? VolumenInicialM3 { get; set; }
        public decimal? VolumenFinalM3 { get; set; }
        public decimal? HorasOperacionH { get; set; }
        public decimal? VolTraspasoM3 { get; set; }
        public decimal? KPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? KTon { get; set; }
        public decimal? NaTon { get; set; }
        public decimal? MgTon { get; set; }
        public decimal? CaTon { get; set; }
        public decimal? So4Ton { get; set; }
        public decimal? LiTon { get; set; }
        public decimal? ClTon { get; set; }
        public decimal? H3bo3Ton { get; set; }
        public decimal? LceTon { get; set; }
    }
}
