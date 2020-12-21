using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataEvaporacionTasa
    {
        public DateTime? Dia { get; set; }
        public double? EvapMm { get; set; }
        public string Origen { get; set; }
    }
}
