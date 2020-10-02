using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ImpregnacionCosechas
    {
        public int IdImpregnacionCosechas { get; set; }
        public int IdPeriodos { get; set; }
        public int IdInfraestructuras { get; set; }
        public int IdSistemasSubsistemas { get; set; }
        public decimal? CosechaTon { get; set; }
        public decimal? CosechaM3 { get; set; }
        public decimal? HumedadPct { get; set; }
        public decimal? KPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? H3bo3Pct { get; set; }
        public int Prioridad { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Infraestructuras IdInfraestructurasNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
        public virtual SistemasSubSistemas IdSistemasSubsistemasNavigation { get; set; }
    }
}
