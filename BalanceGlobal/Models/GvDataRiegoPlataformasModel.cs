using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataRiegoPlataformasModel : ModelBase
    {
        [Required] public int IdRiegoPlataformas { get; set; }
        public string Periodo { get; set; }
        public decimal? VolConsumoH2oM3 { get; set; }
    }
}
