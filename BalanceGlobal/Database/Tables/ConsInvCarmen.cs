using System;

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
    }
}
