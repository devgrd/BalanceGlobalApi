using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class TipoDatoControlModel : ModelBase
    {

        [Required] public int IdTipoDatoControl { get; set; }
        public string TipoDatoControl1 { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }

    }
}
