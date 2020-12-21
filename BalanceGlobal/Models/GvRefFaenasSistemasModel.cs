using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvRefFaenasSistemasModel : ModelBase
    {
        [Required] public int IdFaenasSistemas { get; set; }
        public string Faena { get; set; }
        [Required] public int IdFaenas { get; set; }
        public string Sistema { get; set; }
        [Required] public int IdSistemas { get; set; }
    }
}
