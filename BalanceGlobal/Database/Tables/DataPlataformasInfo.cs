using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataPlataformasInfo
    {
        public DateTime? Fecha { get; set; }
        public double? VolAgua { get; set; }
        public double? Salmuera { get; set; }
        public double? VolSal { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public double? PDeImpregnación { get; set; }
        public double? PDeLiInicial { get; set; }
        public string Plataforma { get; set; }
    }
}
