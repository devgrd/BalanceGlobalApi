using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ProdyDespSdeAvariablesNumModel : ModelBase
    {

        [Required] public int IdProdyDespSdeAvariablesNum { get; set; }
        public string Variable { get; set; }
        public string Descripcion { get; set; }
        [Required] public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
