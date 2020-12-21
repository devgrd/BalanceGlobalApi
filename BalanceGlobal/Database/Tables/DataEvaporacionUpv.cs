using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataEvaporacionUpv
    {
        public DateTime? Fecha { get; set; }
        public string Infraestructura { get; set; }
        public double? Valor { get; set; }
        public string Variable { get; set; }
        public string Origen { get; set; }
    }
}
