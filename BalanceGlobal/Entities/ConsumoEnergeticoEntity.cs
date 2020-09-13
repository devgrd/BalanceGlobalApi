using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public class ConsumoEnergetico
    {
        public int IdConsumoEnergetico { get; set; }
        public int IdPeriodos { get; set; }
        public string Up { get; set; }
        public string UpD { get; set; }
        public string Concepto { get; set; }
        public string ConceptoD { get; set; }
        public string Um { get; set; }
        public decimal? Valor { get; set; }
    }
}
