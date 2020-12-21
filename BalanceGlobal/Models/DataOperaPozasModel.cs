using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataOperaPozasModel : ModelBase
    {
        public string Fecha { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Inicial { get; set; }
        public string Final { get; set; }
        public string Horometro { get; set; }
        public string VolTraspaso { get; set; }
        public string K { get; set; }
        public string Mg { get; set; }
        public string Li { get; set; }
        public string So4 { get; set; }
        public string Na { get; set; }
        public string H3bo3 { get; set; }
        public string Ca { get; set; }
        public string Cl { get; set; }
        public string Densidad { get; set; }
        public string Sistema { get; set; }
        public string Caudal { get; set; }
        public double? SatK { get; set; }
        public string B { get; set; }
    }
}
