using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ReinyeccionModel : ModelBase
    {
        [Required] public int IdReinyeccion { get; set; }
        [Required] public int IdSistemasSubsitemas { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? EvapAreaExpuestaM3dia { get; set; }
        public decimal? EvapAreaImpM3dia { get; set; }
        public decimal? SalmueraInfiltradaM3dia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
