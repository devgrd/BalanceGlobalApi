using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataEvaporacionPermeabilidad
    {
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public double? Permeabilidad { get; set; }
    }
}
