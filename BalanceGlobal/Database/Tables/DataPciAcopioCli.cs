using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataPciAcopioCli
    {
        public DateTime? FechaOrigen { get; set; }
        public string AcopioCli { get; set; }
        public DateTime? Fecha { get; set; }
        public long? VolumenM3 { get; set; }
        public double? Li { get; set; }
        public long? Densidad { get; set; }
    }
}
