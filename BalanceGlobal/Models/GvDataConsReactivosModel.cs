using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataConsReactivosModel : ModelBase
    {
        [Required] public int IdConsReactivos { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string Periodo { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public string Reactivo { get; set; }
        public string Unidad { get; set; }
        public decimal? Valor { get; set; }
    }
}
