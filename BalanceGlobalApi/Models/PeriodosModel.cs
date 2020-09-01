using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BalanceGlobal.Api.Models
{
    public class PeriodosModel
    {
        public int IdPeriodos { get; set; }
        [Required]
        public string Periodo { get; set; }
        public int? IdTipoPeriodo { get; set; }
        [Required]
        public bool? Activa { get; set; }
    }
}
