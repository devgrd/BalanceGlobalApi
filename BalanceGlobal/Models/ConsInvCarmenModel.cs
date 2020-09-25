using System.ComponentModel.DataAnnotations;
using System;

namespace BalanceGlobal.Models
{
    public class ConsInvCarmenModel : ModelBase
    {
        [Required] public int IdConsInvCarmen { get; set; }
        [Required] public int IdSistemasSubSistemas { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdInfraestructuras { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? VolumenM3 { get; set; }
        public decimal? DensidadTomm3 { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? MasaLceTon { get; set; }
        public decimal? KPct { get; set; }
        public decimal? MasaBalanceLceTon { get; set; }
    }
}
