using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataReinyeccionFlujos
    {
        public DateTime? Fecha { get; set; }
        public string Variable { get; set; }
        public double? Value { get; set; }
        public string Sistema { get; set; }
    }
}
