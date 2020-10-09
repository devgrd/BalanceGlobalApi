using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class SuscripcionEventosModel : ModelBase
    {
        [Required] public int IdSuscripcionEventos { get; set; }
        [Required] public int IdEventos { get; set; }
        [Required] public int IdUsuarios { get; set; }

    }
}
