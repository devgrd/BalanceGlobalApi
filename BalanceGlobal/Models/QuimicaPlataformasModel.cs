using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class QuimicaPlataformasModel : ModelBase
    {
        [Required] public int IdQuimicaPlataformas { get; set; }
        [Required] public int IdPlataforma { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? KPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
