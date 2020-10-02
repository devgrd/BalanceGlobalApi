using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class RiegoPlataformasModel : ModelBase
    {
        [Required] public int IdRiegoPlataformas { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public decimal VolConsumoH2oM3 { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
