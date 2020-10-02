using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class CkmopIivolaPorteo
    {
        public int IdCkmopIivolaPorteo { get; set; }
        public int IdPeriodos { get; set; }
        public int IdInfraestructuras { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? VolumenM3dia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Infraestructuras IdInfraestructurasNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
    }
}
