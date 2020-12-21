using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataSistemaFaenaModel : ModelBase
    {
        public string Sistema { get; set; }
        public string Faena { get; set; }
    }
}
