using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class MultiAliases
    {
        public int IdMultiAliases { get; set; }
        public string Importador { get; set; }
        public string Campo1 { get; set; }
        public string ValorOriginal1 { get; set; }
        public string Alias1 { get; set; }
        public string Campo2 { get; set; }
        public string ValorOriginal2 { get; set; }
        public string Alias2 { get; set; }
    }
}
