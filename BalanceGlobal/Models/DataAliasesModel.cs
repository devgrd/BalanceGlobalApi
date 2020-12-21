using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataAliasesModel : ModelBase
    {
        public long? IdAliases { get; set; }
        public string Importador { get; set; }
        public string Campo { get; set; }
        public string ValorOriginal { get; set; }
        public string ValorAlias { get; set; }
        public string Observaciones { get; set; }
    }
}
