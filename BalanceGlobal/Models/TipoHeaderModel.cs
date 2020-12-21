using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class TipoHeaderModel : ModelBase
    {

        [Required] public int IdTipoHeader { get; set; }
        public string TipoHeader1 { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }

    }
}
