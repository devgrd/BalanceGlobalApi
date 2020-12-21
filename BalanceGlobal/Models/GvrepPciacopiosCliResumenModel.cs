using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvrepPciacopiosCliResumenModel : ModelBase
    {
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        [Required] public decimal MasaTon { get; set; }
        public decimal? LiPct { get; set; }
        [Required] public decimal LceTon { get; set; }
    }
}
