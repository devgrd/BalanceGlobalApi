using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataPeriodosOperacionalesModel : ModelBase
    {
        public string Sistema { get; set; }
        public DateTime? Mes { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
    }
}
