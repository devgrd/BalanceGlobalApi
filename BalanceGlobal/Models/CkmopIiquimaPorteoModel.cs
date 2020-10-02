using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class CkmopIiquimaPorteoModel : ModelBase
    {
        [Required] public int IdCkmopIiquimaPorteo { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdInfraestructuras { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? KPct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
