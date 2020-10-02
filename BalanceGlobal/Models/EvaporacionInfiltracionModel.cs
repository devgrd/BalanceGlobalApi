using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class EvaporacionInfiltracionModel : ModelBase
    {
        [Required] public int IdEvaporacionInfiltracion { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdSistemas { get; set; }
        [Required] public int IdInfraestructuras { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? AlturaSalmueraM { get; set; }
        public decimal? AreaM2 { get; set; }
        public decimal? KPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        public decimal? ClPct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
