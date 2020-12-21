using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataImpregnacionCosechasModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string Sistema { get; set; }
        public string Poza { get; set; }
        public string NProd { get; set; }
        public double? CosechaTon { get; set; }
        public double? CosechaM3 { get; set; }
        public double? Hum { get; set; }
        public double? K { get; set; }
        public double? Mg { get; set; }
        public double? Li { get; set; }
        public double? So4 { get; set; }
        public double? Ca { get; set; }
        public double? Cl { get; set; }
        public double? Na { get; set; }
        public double? H3bo3 { get; set; }
    }
}
