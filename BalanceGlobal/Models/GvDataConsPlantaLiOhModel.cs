using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataConsPlantaLiOhModel : ModelBase
    {
        [Required] public int IdConsPlantaLiOh { get; set; }
        public string Periodo { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? Li2Co3Pct { get; set; }
    }
}
