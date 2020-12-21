using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataProdyDespSdeAconsProdK1Model : ModelBase
    {
        [Required] public int IdProdyDespSdeAconsProdK1 { get; set; }
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string ModalidadPlanta { get; set; }
        public string Corriente { get; set; }
        public string Subsistema { get; set; }
        public string Infraestructura { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public string Variable { get; set; }
        public decimal? Valor { get; set; }
    }
}
