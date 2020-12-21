using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataPlataformasRiegoModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public double? ConsumoAguaM3 { get; set; }
    }
}
