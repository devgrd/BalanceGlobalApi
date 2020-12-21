using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataFlujosModel : ModelBase
    {
        [Required] public int IdFlujos { get; set; }
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string Bomba { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? TotalizadorM3 { get; set; }
    }
}
