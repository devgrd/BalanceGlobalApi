using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvdataPciacopioCli
    {
        public int IdPciacopiosCli { get; set; }
        public string Acopio { get; set; }
        public string Periodo { get; set; }
        public decimal? VolumenM3 { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        public int Prioridad { get; set; }
    }
}
