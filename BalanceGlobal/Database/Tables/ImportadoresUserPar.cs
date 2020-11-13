using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ImportadoresUserPar
    {
        public ImportadoresUserPar()
        {
            SchemaColumns = new HashSet<SchemaColumns>();
        }

        public int IdImportadoresUserPar { get; set; }
        public int IdImportadores { get; set; }
        public string UserPar { get; set; }
        public int IdTipoDatoControl { get; set; }
        public bool? Activa { get; set; }

        public virtual ICollection<SchemaColumns> SchemaColumns { get; set; }
    }
}
