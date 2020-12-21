using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataEvaporacionPermeabilidadModel : ModelBase
    {
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public double? Permeabilidad { get; set; }
    }
}
