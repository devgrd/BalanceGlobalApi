using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataEvaporacionTasaModel : ModelBase
    {
        public DateTime? Dia { get; set; }
        public double? EvapMm { get; set; }
        public string Origen { get; set; }
    }
}
