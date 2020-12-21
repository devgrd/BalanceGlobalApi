using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ImpregnacionSistemaRefModel : ModelBase
    {
        [Required] public int IdImpregnacionSistemaRef { get; set; }
        [Required] public int IdSubSistemas { get; set; }
        public decimal? ImpregnacionTotal { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
