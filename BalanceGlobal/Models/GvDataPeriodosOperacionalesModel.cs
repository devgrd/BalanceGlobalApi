using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataPeriodosOperacionalesModel : ModelBase
    {
        [Required] public int IdPeriodosOperacionales { get; set; }
        public string Sistema { get; set; }
        public string Periodo { get; set; }
        [Required] public DateTime FechaInicio { get; set; }
        [Required] public DateTime FechaFin { get; set; }
    }
}
