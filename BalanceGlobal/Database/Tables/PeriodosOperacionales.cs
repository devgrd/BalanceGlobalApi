using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class PeriodosOperacionales
    {
        public int IdPeriodosOperacionales { get; set; }
        public int IdSistemas { get; set; }
        public int IdPeriodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Real { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Periodos IdPeriodoNavigation { get; set; }
        public virtual Sistemas IdSistemasNavigation { get; set; }
    }
}
