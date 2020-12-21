using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class PueblaTablaReporteBalanceLogEjecucionModel : ModelBase
    {
        [Required] public int IdEjecucion { get; set; }
        [Required] public DateTime FechaEjecucion { get; set; }
        public string UsuarioEjecucion { get; set; }
        [Required] public bool FinalizoEjecucion { get; set; }
        public string ErrorMensaje { get; set; }
        public Guid? Uidkey { get; set; }
    }
}
