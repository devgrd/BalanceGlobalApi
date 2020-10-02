using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ConsReactivosModel : ModelBase
    {
        [Required] public int IdConsReactivos { get; set; }
        [Required] public int IdSistemasSubSistemas { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public DateTime Fecha { get; set; }
        [Required] public int IdReactivos { get; set; }
        public decimal? Valor { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
