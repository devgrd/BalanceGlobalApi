using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataConsumoAguaModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string Variable { get; set; }
        public double? Value { get; set; }
        public string GrupoReporte { get; set; }
    }
}
