using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class FlujosModel : ModelBase
    {
        [Required] public int IdFlujos { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdSistemasSubsistemas { get; set; }
        [Required] public int IdBombas { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? TotalizadorM3 { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
