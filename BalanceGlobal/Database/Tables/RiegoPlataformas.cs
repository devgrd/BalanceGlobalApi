using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class RiegoPlataformas
    {
        public int IdRiegoPlataformas { get; set; }
        public int IdPeriodos { get; set; }
        public decimal? VolConsumoH2oM3 { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Periodos IdPeriodosNavigation { get; set; }
    }
}
