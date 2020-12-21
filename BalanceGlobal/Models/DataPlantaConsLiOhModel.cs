using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataPlantaConsLiOhModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public double? Li2Co3T { get; set; }
    }
}
