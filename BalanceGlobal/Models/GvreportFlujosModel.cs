using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvreportFlujosModel : ModelBase
    {
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? Flujo { get; set; }
        public decimal? FlujoDifM3 { get; set; }
    }
}
