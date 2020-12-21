using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataProduccionPotasioConsProdKModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string Name { get; set; }
        public double? Value { get; set; }
    }
}
