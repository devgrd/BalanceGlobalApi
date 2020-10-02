using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class InventariosAtacamaModel : ModelBase
    {
        [Required] public int IdInventariosAtacama { get; set; }
        [Required] public int IdSistemasSubsistemas { get; set; }
        [Required] public int IdTiposInventario { get; set; }
        [Required] public int IdPeriodo { get; set; }
        public decimal? Factor { get; set; }
        [Required] public int IdInfraestructuras { get; set; }
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
        [Required] public int Prioridad { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
