using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class PcimodosModel : ModelBase
    {
        [Required] public int IdPcimodos { get; set; }
        [Required] public int IdModalidadPci { get; set; }
        [Required] public int IdCorrientePci { get; set; }
        [Required] public int IdInfrestructuras { get; set; }
        [Required] public int IdTipoPci { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdSistemasSubsistemas { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? KPct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? MasaLceTon { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
