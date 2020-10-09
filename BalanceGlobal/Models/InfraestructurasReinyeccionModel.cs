using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class InfraestructurasReinyeccionModel : ModelBase
    {
        [Required] public int IdInfraestructurasReinyeccion { get; set; }
        [Required] public int IdInfraestructuras { get; set; }
        [Required] public int IdSistemasSubsistemas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
