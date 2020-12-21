using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class TipoOrigenModel : ModelBase
    {

        [Required] public int IdTipoOrigen { get; set; }
        public string TipoOrigen1 { get; set; }

    }
}
