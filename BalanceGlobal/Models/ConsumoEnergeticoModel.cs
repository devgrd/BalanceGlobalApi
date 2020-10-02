using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ConsumoEnergeticoModel : ModelBase
    {
        [Required] public int IdConsumoEnergetico { get; set; }
        [Required] public int IdPeriodos { get; set; }
        public string Up { get; set; }
        public string UpD { get; set; }
        public string Concepto { get; set; }
        public string ConceptoD { get; set; }
        public string Um { get; set; }
        public decimal? Valor { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
