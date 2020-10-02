using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ConsPlantaLiOhModel : ModelBase
    {
        [Required] public int IdConsPlantaLiOh { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? Li2Co3Pct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
