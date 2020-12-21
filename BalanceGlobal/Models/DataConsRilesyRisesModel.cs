using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataConsRilesyRisesModel : ModelBase
    {
        public string Fecha { get; set; }
        public string Corriente { get; set; }
        public string Salar { get; set; }
        public string Sistema { get; set; }
        public string Tipo { get; set; }
        public double? MasaTon { get; set; }
        public double? K { get; set; }
        public double? Na { get; set; }
        public double? Mg { get; set; }
        public double? Ca { get; set; }
        public double? So4 { get; set; }
        public double? Li { get; set; }
        public double? Cl { get; set; }
        public double? H3bo3 { get; set; }
    }
}
