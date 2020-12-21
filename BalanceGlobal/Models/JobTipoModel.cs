using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class JobTipoModel : ModelBase
    {

        [Required] public int IdJobTipo { get; set; }
        public string JobTipo1 { get; set; }

    }
}
