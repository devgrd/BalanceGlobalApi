using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataPciFechasdeOrigenModel : ModelBase
    {
        public string Acopio { get; set; }
        public DateTime? FechaDeOrigen { get; set; }
        public string SalRes { get; set; }
    }
}
