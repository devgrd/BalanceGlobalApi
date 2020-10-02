using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ConsPlantaLiOh
    {
        public int IdConsPlantaLiOh { get; set; }
        public int IdPeriodos { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Li2Co3Pct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Periodos IdPeriodosNavigation { get; set; }
    }
}
