using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvRefSistemasSubsistemasModel : ModelBase
    {
        [Required] public int IdSistemasSubsistemas { get; set; }
        public string Sistema { get; set; }
        [Required] public int IdSistemas { get; set; }
        public string Subsistema { get; set; }
        public int? IdSubsistemas { get; set; }
    }
}
