using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataPciModosModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string Planta { get; set; }
        public double? Valor { get; set; }
        public string Corriente { get; set; }
        public string Tipo { get; set; }
        public string Variable { get; set; }
        public string Modo { get; set; }
    }
}
