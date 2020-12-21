using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class AliasesModel : ModelBase
    {
        [Required] public int IdAliases { get; set; }
        public string Importador { get; set; }
        public string Campo { get; set; }
        public string ValorOriginal { get; set; }
        public string ValorAlias { get; set; }
    }

    
}
