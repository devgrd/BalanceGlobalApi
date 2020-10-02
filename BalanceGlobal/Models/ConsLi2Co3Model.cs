using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ConsLi2Co3Model : ModelBase
    {
        [Required] public int IdConsLi2Co3 { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public DateTime Fecha { get; set; }
        [Required] public int IdCorrienteGlobal { get; set; }
        [Required] public int IdCorrienteLi2Co3 { get; set; }
        public decimal? VolM3 { get; set; }
        public decimal? DensTonm3 { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? KPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? BPct { get; set; }
        public decimal? Co3Pct { get; set; }
        public decimal? OhPct { get; set; }
        public decimal? H2oPct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
