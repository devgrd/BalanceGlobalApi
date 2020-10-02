using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ConsumoAguaModel : ModelBase
    {
        [Required] public int IdConsumoAgua { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdCategoriaConsumoAgua { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? VolAguaM3 { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
