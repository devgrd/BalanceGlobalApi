using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataPermeabilidadModel : ModelBase
    {
        [Required] public int IdPermeabilidad { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public decimal? PermeabilidadM3m2dia { get; set; }
    }
}
