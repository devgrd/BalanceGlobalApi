using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ConsReactivos
    {
        public int IdConsReactivos { get; set; }
        public int IdSistemasSubSistemas { get; set; }
        public int IdPeriodos { get; set; }
        public DateTime Fecha { get; set; }
        public int IdReactivos { get; set; }
        public decimal? Valor { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Periodos IdPeriodosNavigation { get; set; }
        public virtual Reactivos IdReactivosNavigation { get; set; }
        public virtual SistemasSubSistemas IdSistemasSubSistemasNavigation { get; set; }
    }
}
