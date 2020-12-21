using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataExtraccionAguaModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public double? Inicial { get; set; }
        public double? Final { get; set; }
        public double? Total { get; set; }
        public double? M3H { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
}
