using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class IckmopIivolaPorteoModel : ModelBase
    {
        public int? IdIckmopIivolaPorteo { get; set; }
        public string Fecha { get; set; }
        public double? Cs15 { get; set; }
        public double? Cs25 { get; set; }
        public double? Cs34 { get; set; }
        public double? E88 { get; set; }
        public double? Ws142 { get; set; }
        public double? Ws1 { get; set; }
        public double? Ws4 { get; set; }
        public double? Ws11 { get; set; }
        public double? Ws41 { get; set; }
        public double? Dps { get; set; }
    }
}
