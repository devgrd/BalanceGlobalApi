using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataPciacopiosOrigenModel : ModelBase
    {
        [Required] public int IdPciacopiosOrigen { get; set; }
        public string Acopio { get; set; }
        [Required] public DateTime FechaOrigen { get; set; }
        public string Subsistema { get; set; }
        [Required] public bool Activa { get; set; }
    }
}
