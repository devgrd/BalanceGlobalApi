using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataPermeabilidad
    {
        public int IdPermeabilidad { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public decimal? PermeabilidadM3m2dia { get; set; }
    }
}
