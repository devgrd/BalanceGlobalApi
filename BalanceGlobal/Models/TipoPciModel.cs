using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class TipoPciModel : ModelBase
    {

        [Required] public int IdTipoPci { get; set; }
        public string TipoPci1 { get; set; }
        public string Descripcion { get; set; }
        [Required] public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
