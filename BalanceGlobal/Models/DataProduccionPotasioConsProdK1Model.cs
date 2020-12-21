using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataProduccionPotasioConsProdK1Model : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string Name { get; set; }
        public double? Value { get; set; }
    }
}
