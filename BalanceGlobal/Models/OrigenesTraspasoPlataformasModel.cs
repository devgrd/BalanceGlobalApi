using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class OrigenesTraspasoPlataformasModel : ModelBase
    {
        [Required] public int IdIdOrigenesTraspasoPlataformas { get; set; }
        [Required] public int IdInfraestructuras { get; set; }
        [Required] public int IdTraspasosPlataformas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
