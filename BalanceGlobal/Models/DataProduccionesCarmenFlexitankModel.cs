using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataProduccionesCarmenFlexitankModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public double? FlexitankLceTon { get; set; }
    }
}
