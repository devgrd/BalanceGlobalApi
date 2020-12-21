using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataTraspasosReiyeccionCkmopiiaPorteoModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public double? VolAgua { get; set; }
        public string Pozo { get; set; }
        public string Variable { get; set; }
    }
}
