using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataRiegoPlataformas
    {
        public int IdRiegoPlataformas { get; set; }
        public string Periodo { get; set; }
        public decimal? VolConsumoH2oM3 { get; set; }
    }
}
