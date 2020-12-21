using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TipoDatoColOrigen
    {
        public TipoDatoColOrigen()
        {
            SchemaColumns = new HashSet<SchemaColumns>();
            SchemaColumnsWarning = new HashSet<SchemaColumnsWarning>();
        }

        public int IdTipoDatoColOrigen { get; set; }
        public string TipoDatoColOrigen1 { get; set; }
        public string Descripcion { get; set; }
        public string PyEquiv { get; set; }
        public string Sqlequiv { get; set; }

        public virtual ICollection<SchemaColumns> SchemaColumns { get; set; }
        public virtual ICollection<SchemaColumnsWarning> SchemaColumnsWarning { get; set; }
    }
}
