using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataPciacopiosOrigen
    {
        public int IdPciacopiosOrigen { get; set; }
        public string Acopio { get; set; }
        public DateTime FechaOrigen { get; set; }
        public string Subsistema { get; set; }
        public bool Activa { get; set; }
    }
}
