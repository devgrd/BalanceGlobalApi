using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ConsLitioLiCo3mensualModel : ModelBase
    {
        [Required] public int IdConsLitioLiCo3mensual { get; set; }
        [Required] public int IdSistemasSubSistemas { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdCorrienteLi2Co3 { get; set; }
        public decimal? Li2Co3FrescaTon { get; set; }
        public decimal? Li2Co3TotalTon { get; set; }
        public decimal? CarbonatoTon { get; set; }
        public decimal? LitioFrescoTon { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
