using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataConsInvCarmen
    {
        public int IdConsInvCarmen { get; set; }
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public DateTime Fecha { get; set; }
        public string Infraestructura { get; set; }
        public decimal? VolumenM3 { get; set; }
        public decimal? DensidadTomm3 { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? MasaLceTon { get; set; }
        public decimal? KPct { get; set; }
        public decimal? MasaBalanceLceTon { get; set; }
    }
}
