using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvCkmopIivolaPorteoModel : ModelBase
    {
        [Required] public int IdCkmopIivolaPorteo { get; set; }
        public string Periodo { get; set; }
        public string Infraestructura { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? VolumenM3dia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
