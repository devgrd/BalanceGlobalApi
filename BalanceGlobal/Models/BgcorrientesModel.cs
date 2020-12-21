using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class BgcorrientesModel : ModelBase
    {

        [Required] public int IdBgcorrientes { get; set; }
        public string Bgcorriente { get; set; }
        public bool? Activa { get; set; }

    }
}
