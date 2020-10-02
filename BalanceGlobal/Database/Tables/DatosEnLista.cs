using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DatosEnLista
    {
        public DatosEnLista()
        {
            SchemaColumns = new HashSet<SchemaColumns>();
            SchemaColumnsWarning = new HashSet<SchemaColumnsWarning>();
        }

        public int IdDatosEnLista { get; set; }
        public string DatosEnLista1 { get; set; }
        public string Lista { get; set; }

        public virtual ICollection<SchemaColumns> SchemaColumns { get; set; }
        public virtual ICollection<SchemaColumnsWarning> SchemaColumnsWarning { get; set; }
    }
}
