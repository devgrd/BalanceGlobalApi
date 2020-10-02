using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class CkmopIivolaPorteoModel : ModelBase
    {
        [Required] public int IdCkmopIivolaPorteo { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdInfraestructuras { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? VolumenM3dia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
