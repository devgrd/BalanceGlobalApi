using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvreporteEvaporacionPeriodoModel : ModelBase
    {
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public decimal? Evaporacion { get; set; }
    }
}
