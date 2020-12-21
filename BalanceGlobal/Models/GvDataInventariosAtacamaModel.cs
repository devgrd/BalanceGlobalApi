using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataInventariosAtacamaModel : ModelBase
    {
        [Required] public int IdInventariosAtacama { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string TipoInventario { get; set; }
        public string Periodo { get; set; }
        public decimal? Factor { get; set; }
        public string Infraestructura { get; set; }
        public decimal? AreaM2 { get; set; }
        public decimal? AlturaSalmueraM { get; set; }
        public decimal? DensGcm3 { get; set; }
        public decimal? Ton { get; set; }
        public decimal? KPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public decimal? KclPct { get; set; }
        public decimal? Li2Co3Eqv { get; set; }
        public decimal? K2so4Eqv { get; set; }
        public decimal? MgCl26h2o { get; set; }
        public decimal? Volumen { get; set; }
        public decimal? VolumenCalculado { get; set; }
        public decimal? ComparacionVol { get; set; }
        public decimal? SatK { get; set; }
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
