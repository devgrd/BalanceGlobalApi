using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class TasaEvaporacionModel : ModelBase
    {
        [Required] public int IdTasaEvaporacion { get; set; }
        [Required] public int IdSistemas { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? TasaEvaporacionMmdia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
