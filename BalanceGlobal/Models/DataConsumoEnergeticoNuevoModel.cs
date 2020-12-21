using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataConsumoEnergeticoNuevoModel : ModelBase
    {
        public string Up { get; set; }
        public string UpD { get; set; }
        public string Concepto { get; set; }
        public string ConceptoD { get; set; }
        public string Um { get; set; }
        public string Tiempo { get; set; }
        public double? SignData { get; set; }
    }
}
