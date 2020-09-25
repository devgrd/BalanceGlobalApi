using System;

namespace BalanceGlobal.Database.Tables
{
    public partial class PeriodosOperacionales
    {
        public int IdPeriodosOperacionales { get; set; }
        public int IdSistemas { get; set; }
        public int IdPeriodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
