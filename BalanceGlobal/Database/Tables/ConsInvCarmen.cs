using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ConsInvCarmen
    {
        public int IdConsInvCarmen { get; set; }
        public int IdSistemasSubSistemas { get; set; }
        public int IdPeriodos { get; set; }
        public int IdInfraestructuras { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? VolumenM3 { get; set; }
        public decimal? DensidadTomm3 { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? MasaLceTon { get; set; }
        public decimal? KPct { get; set; }
        public decimal? MasaBalanceLceTon { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Infraestructuras IdInfraestructurasNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
        public virtual SistemasSubSistemas IdSistemasSubSistemasNavigation { get; set; }
    }
}
