using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class TipoMensajeModel : ModelBase
    {

        [Required] public int IdTipoMensaje { get; set; }
        public string TipoMensaje1 { get; set; }

    }
}
