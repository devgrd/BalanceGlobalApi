using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvCkmopIiquimaPorteo
    {
        public int IdCkmopIiquimaPorteo { get; set; }
        public string Periodo { get; set; }
        public string Infraestructura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? KPct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
