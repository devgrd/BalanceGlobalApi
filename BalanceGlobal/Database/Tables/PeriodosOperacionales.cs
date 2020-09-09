using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class PeriodosOperacionales
    {
        public int IdPeriodosOpercionales { get; set; }
        public int IdSistemas { get; set; }
        public int IdPeriodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
