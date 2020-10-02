using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class PeriodosOperacionalesModel : ModelBase
    {
        [Required] public int IdPeriodosOperacionales { get; set; }
        [Required] public int IdSistemas { get; set; }
        [Required] public int IdPeriodo { get; set; }
        [Required] public DateTime FechaInicio { get; set; }
        [Required] public DateTime FechaFin { get; set; }
        [Required] public bool Real { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
