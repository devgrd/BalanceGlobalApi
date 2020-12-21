using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataImpregnacionRefModel : ModelBase
    {
        public string TipoPoza { get; set; }
        public double? ImpregnacionTotal { get; set; }
    }
}
