using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataReactivos
    {
        public DateTime? Fecha { get; set; }
        public string Corriente { get; set; }
        public double? Volumen { get; set; }
        public double? Densidad { get; set; }
        public double? MasaTon { get; set; }
    }
}
