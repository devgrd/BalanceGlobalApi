using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class CorrienteLi2Co3Model : ModelBase
    {

        [Required] public int IdCorrienteLi2Co3 { get; set; }
        public string CorrienteLi2Co31 { get; set; }
        public string Descipcion { get; set; }
        [Required] public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
