using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class IextraccionModel : ModelBase
    {
        public int? IdIextraccion { get; set; }
        public string Fecha { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public double? Inicial { get; set; }
        public double? Final { get; set; }
        public double? Horas { get; set; }
        public double? VolTraspaso { get; set; }
        public double? K { get; set; }
        public double? Na { get; set; }
        public double? Mg { get; set; }
        public double? Ca { get; set; }
        public double? So4 { get; set; }
        public double? Li { get; set; }
        public double? Cl { get; set; }
        public double? Densidad { get; set; }
        public double? H3bo3 { get; set; }
    }
}
