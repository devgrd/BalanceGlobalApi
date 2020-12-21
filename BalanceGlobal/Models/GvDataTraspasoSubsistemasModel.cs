using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataTraspasoSubsistemasModel : ModelBase
    {
        [Required] public int IdOperaPozas { get; set; }
        public string Periodo { get; set; }
        public string SistemaOrigen { get; set; }
        public string PeriodoOperacional { get; set; }
        public string SubSistemaOrigen { get; set; }
        public string SubSistemaDestino { get; set; }
        public string SistemaDestino { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public decimal? VolumenInicialM3 { get; set; }
        public decimal? VolumenFinalM3 { get; set; }
        public decimal? VolumenTraspasoM3 { get; set; }
        public decimal? Horometro { get; set; }
        public decimal? CaudalInstantaneoM3s { get; set; }
        public decimal? BPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? KPct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? SatK { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? BTon { get; set; }
        public decimal? CaTon { get; set; }
        public decimal? ClTon { get; set; }
        public decimal? KTon { get; set; }
        public decimal? LiTon { get; set; }
        public decimal? MgTon { get; set; }
        public decimal? NaTon { get; set; }
        public decimal? So4Ton { get; set; }
        public decimal? H3bo3Ton { get; set; }
        public decimal? LceTon { get; set; }
    }
}
