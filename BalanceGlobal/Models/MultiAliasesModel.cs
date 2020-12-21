using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class MultiAliasesModel : ModelBase
    {
        [Required] public int IdMultiAliases { get; set; }
        public string Importador { get; set; }
        public string Campo1 { get; set; }
        public string ValorOriginal1 { get; set; }
        public string Alias1 { get; set; }
        public string Campo2 { get; set; }
        public string ValorOriginal2 { get; set; }
        public string Alias2 { get; set; }
    }
}
