using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataEvaporacionUpvModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string Infraestructura { get; set; }
        public double? Valor { get; set; }
        public string Variable { get; set; }
        public string Origen { get; set; }
    }
}
