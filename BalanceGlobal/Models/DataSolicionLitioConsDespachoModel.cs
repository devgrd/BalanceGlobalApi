using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataSolicionLitioConsDespachoModel : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string String { get; set; }
        public double? MasaDespachadaTon { get; set; }
        public double? NroCam { get; set; }
        public double? DensTonm3 { get; set; }
        public double? LiPct { get; set; }
        public double? MgPct { get; set; }
        public double? KPct { get; set; }
        public double? So4Pct { get; set; }
        public double? NaPct { get; set; }
        public double? CaPct { get; set; }
        public double? BPct { get; set; }
        public double? SoldPct { get; set; }
    }
}
