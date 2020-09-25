using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class PeriodosModel : ModelBase
    {

        [Required] public int IdPeriodos { get; set; }
        public string Periodo { get; set; }
        public int? IdTipoPeriodo { get; set; }
        public bool? Activa { get; set; }

    }
}
