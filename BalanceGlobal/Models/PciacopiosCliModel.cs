using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class PciacopiosCliModel : ModelBase
    {
        [Required] public int IdPciacopiosCli { get; set; }
        [Required] public int IdPciacopiosOrigen { get; set; }
        [Required] public int IdPeriodos { get; set; }
        public decimal? VolumenM3 { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        [Required] public int Prioridad { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
