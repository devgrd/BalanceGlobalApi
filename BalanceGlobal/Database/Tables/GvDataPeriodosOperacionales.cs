using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataPeriodosOperacionales
    {
        public int IdPeriodosOperacionales { get; set; }
        public string Sistema { get; set; }
        public string Periodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
