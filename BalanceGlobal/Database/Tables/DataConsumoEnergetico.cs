using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataConsumoEnergetico
    {
        public string Version { get; set; }
        public string Up { get; set; }
        public long? Concepto { get; set; }
        public string Cuenta { get; set; }
        public string Fuente { get; set; }
        public string Moneda { get; set; }
        public string Producto { get; set; }
        public long? TimeidSap { get; set; }
        public double? SignData { get; set; }
    }
}
