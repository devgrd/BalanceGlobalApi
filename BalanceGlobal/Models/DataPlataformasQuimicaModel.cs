using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataPlataformasQuimicaModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public double? Li { get; set; }
        public double? Mg { get; set; }
        public double? K { get; set; }
        public double? Na { get; set; }
        public double? Ca { get; set; }
        public double? So4 { get; set; }
        public double? Cl { get; set; }
        public double? H3bo3 { get; set; }
        public double? Densidad { get; set; }
        public string Plataforma { get; set; }
    }
}
