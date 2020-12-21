using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class IdiomaFecha
    {
        public IdiomaFecha()
        {
            SchemaColumns = new HashSet<SchemaColumns>();
            SchemaColumnsWarning = new HashSet<SchemaColumnsWarning>();
        }

        public int IdIdiomaFecha { get; set; }
        public string IdiomaFecha1 { get; set; }

        public virtual ICollection<SchemaColumns> SchemaColumns { get; set; }
        public virtual ICollection<SchemaColumnsWarning> SchemaColumnsWarning { get; set; }
    }
}
