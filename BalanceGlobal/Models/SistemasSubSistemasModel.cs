using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class SistemasSubSistemasModel : ModelBase
    {

        [Required] public int IdSistemasSubsistemas { get; set; }
        [Required] public int IdSistemas { get; set; }
        public int? IdSubSistemas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string GrupoReporte { get; set; }

    }
}
