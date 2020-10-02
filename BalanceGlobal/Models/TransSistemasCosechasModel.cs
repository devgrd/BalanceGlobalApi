using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class TransSistemasCosechasModel : ModelBase
    {
        [Required] public int IdTransSistemasCosechas { get; set; }
        public string SistemaOrigen { get; set; }
        public string SubsistemaOrigen { get; set; }
        [Required] public int IdSistemasSubsistemas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
