using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class CorrienteGlobalModel : ModelBase
    {

        [Required] public int IdCorrienteGlobal { get; set; }
        public string CorrienteGlobal1 { get; set; }
        public string Descipcion { get; set; }
        [Required] public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
