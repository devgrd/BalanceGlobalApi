using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class BgtiposModel : ModelBase
    {

        [Required] public int IdBgtipos { get; set; }
        public string Tipo { get; set; }
        public bool? Activa { get; set; }

    }
}
