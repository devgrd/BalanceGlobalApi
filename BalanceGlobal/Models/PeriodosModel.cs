using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class PeriodosModel : ModelBase
    {

        [Required] public int IdPeriodos { get; set; }
        public string Periodo { get; set; }
        public int? IdTipoPeriodo { get; set; }
        public bool? Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
