using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ConsRilesyRises
    {
        public int IdConsRilesyRises { get; set; }
        public int IdPeriodos { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCorrienteRilesyRises { get; set; }
        public int IdSistemas { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? KPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual CorrientesRilesyRises IdCorrienteRilesyRisesNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
        public virtual Sistemas IdSistemasNavigation { get; set; }
    }
}
