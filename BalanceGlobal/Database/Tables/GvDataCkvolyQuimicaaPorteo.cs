using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataCkvolyQuimicaaPorteo
    {
        public int IdCkmopIivolaPorteo { get; set; }
        public string Periodo { get; set; }
        public string Infraestructura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? VolumenM3dia { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? KPct { get; set; }
        public decimal? DensidadTonm3 { get; set; }
    }
}
