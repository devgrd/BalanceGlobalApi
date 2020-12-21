using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataTasaEvaporacionModel : ModelBase
    {
        [Required] public int IdTasaEvaporacion { get; set; }
        public string Sistema { get; set; }
        public string Periodo { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? TasaEvaporacionMmdia { get; set; }
    }
}
