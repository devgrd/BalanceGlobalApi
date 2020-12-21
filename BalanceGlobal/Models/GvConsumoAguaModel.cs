using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvConsumoAguaModel : ModelBase
    {
        [Required] public int IdConsumoAgua { get; set; }
        public string Periodo { get; set; }
        public string CategoriasConsumoAgua { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? VolAguaM3 { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
