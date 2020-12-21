using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class PueblaTablaReporteBalanceLogEjecucion
    {
        public int IdEjecucion { get; set; }
        public DateTime FechaEjecucion { get; set; }
        public string UsuarioEjecucion { get; set; }
        public bool FinalizoEjecucion { get; set; }
        public string ErrorMensaje { get; set; }
        public Guid? Uidkey { get; set; }
    }
}
