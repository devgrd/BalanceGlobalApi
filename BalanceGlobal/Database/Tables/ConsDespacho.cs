using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ConsDespacho
    {
        public int IdConsDespacho { get; set; }
        public int IdPeriodos { get; set; }
        public DateTime Fecha { get; set; }
        public string String { get; set; }
        public decimal? MasaDespachadaTon { get; set; }
        public decimal? Nrocam { get; set; }
        public decimal? DensTonm3 { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? KPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? BPct { get; set; }
        public decimal? SoldPct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Periodos IdPeriodosNavigation { get; set; }
    }
}
