using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataTraspasosReiyeccionHoja2Model : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public double? Valor { get; set; }
        public string Pozo { get; set; }
        public string Variable { get; set; }
    }
}
