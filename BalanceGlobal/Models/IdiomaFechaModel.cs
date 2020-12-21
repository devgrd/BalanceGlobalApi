using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class IdiomaFechaModel : ModelBase
    {

        [Required] public int IdIdiomaFecha { get; set; }
        public string IdiomaFecha1 { get; set; }

    }
}
