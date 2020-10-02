using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class PermeabilidadModel : ModelBase
    {
        [Required] public int IdPermeabilidad { get; set; }
        [Required] public int IdSistemasSubsistemas { get; set; }
        public decimal? PermeabilidadM3m2dia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
