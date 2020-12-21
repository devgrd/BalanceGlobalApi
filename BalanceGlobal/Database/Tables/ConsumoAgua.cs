using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ConsumoAgua
    {
        public int IdConsumoAgua { get; set; }
        public int IdPeriodos { get; set; }
        public int IdCategoriaConsumoAgua { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? VolAguaM3 { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual CategoriaConsumoAgua IdCategoriaConsumoAguaNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
    }
}
