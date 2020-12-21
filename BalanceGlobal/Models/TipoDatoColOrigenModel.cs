using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class TipoDatoColOrigenModel : ModelBase
    {

        [Required] public int IdTipoDatoColOrigen { get; set; }
        public string TipoDatoColOrigen1 { get; set; }
        public string Descripcion { get; set; }
        public string PyEquiv { get; set; }
        public string Sqlequiv { get; set; }

    }
}
