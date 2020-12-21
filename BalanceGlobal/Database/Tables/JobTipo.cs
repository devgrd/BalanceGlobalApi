using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class JobTipo
    {
        public JobTipo()
        {
            ImportDestino = new HashSet<ImportDestino>();
        }

        public int IdJobTipo { get; set; }
        public string JobTipo1 { get; set; }

        public virtual ICollection<ImportDestino> ImportDestino { get; set; }
    }
}
