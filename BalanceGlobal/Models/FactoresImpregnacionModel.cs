using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class FactoresImpregnacionModel : ModelBase
    {
        [Required] public int IdFactoresImpregnacion { get; set; }
        public string IdSistema { get; set; }
        [Required] public int IdTipoSal { get; set; }
        [Required] public decimal FactorM3m2 { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
