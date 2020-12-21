using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvreportConsumoAgua
    {
        public string Periodo { get; set; }
        public string GrupoReporte { get; set; }
        public string SuperGrupoReporte { get; set; }
        public decimal? VolAguaM3 { get; set; }
    }
}
