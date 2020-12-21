using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataCosechasSistemaCambiadoModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string Sistema { get; set; }
        public string Pozas { get; set; }
        public string Descripción { get; set; }
        public string AlturaDePozasM { get; set; }
        public double? CosechaTon { get; set; }
        public double? CosechaM3 { get; set; }
        public double? Densidad { get; set; }
        public double? K { get; set; }
        public double? Na { get; set; }
        public double? Mg { get; set; }
        public double? Ca { get; set; }
        public double? So4 { get; set; }
        public double? Li { get; set; }
        public double? Cl { get; set; }
        public double? H3bo3 { get; set; }
        public double? Imprg { get; set; }
        public double? Hum { get; set; }
    }
}
