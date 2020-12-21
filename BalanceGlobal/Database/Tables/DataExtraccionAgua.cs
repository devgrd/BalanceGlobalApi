using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataExtraccionAgua
    {
        public DateTime? Fecha { get; set; }
        public double? Inicial { get; set; }
        public double? Final { get; set; }
        public double? Total { get; set; }
        public double? M3H { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
}
