using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataReactivosModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string Corriente { get; set; }
        public double? Volumen { get; set; }
        public double? Densidad { get; set; }
        public double? MasaTon { get; set; }
    }
}
