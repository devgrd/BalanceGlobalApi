using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ItasaEvaporacionModel : ModelBase
    {
        public int? IdItasaEvaporacion { get; set; }
        public string Dia { get; set; }
        public double? VelViento { get; set; }
        public double? TMin { get; set; }
        public double? Tmáx { get; set; }
        public double? HumProm { get; set; }
        public double? HumMin { get; set; }
        public double? HumMax { get; set; }
        public double? RadSolar { get; set; }
        public double? PresiónAtm { get; set; }
        public double? PrecipTot { get; set; }
        public double? TPromedio { get; set; }
        public double? EvapMáx1 { get; set; }
        public double? EvapMáx2 { get; set; }
        public double? Dif12 { get; set; }
        public double? PromEvp { get; set; }
    }
}
