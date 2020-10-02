using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class CkmopIiquimaPorteo
    {
        public int IdCkmopIiquimaPorteo { get; set; }
        public int IdPeriodos { get; set; }
        public int IdInfraestructuras { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? KPct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Infraestructuras IdInfraestructurasNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
    }
}
