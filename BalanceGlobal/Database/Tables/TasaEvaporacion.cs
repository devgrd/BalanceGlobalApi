using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TasaEvaporacion
    {
        public int IdTasaEvaporacion { get; set; }
        public int IdSistemas { get; set; }
        public int IdPeriodos { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? TasaEvaporacionMmdia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Periodos IdPeriodosNavigation { get; set; }
        public virtual Sistemas IdSistemasNavigation { get; set; }
    }
}
