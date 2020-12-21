using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ImportadoresUserPar
    {
        public ImportadoresUserPar()
        {
            ImportacionesUserParValues = new HashSet<ImportacionesUserParValues>();
            SchemaColumns = new HashSet<SchemaColumns>();
        }

        public int IdImportadoresUserPar { get; set; }
        public int IdImportadores { get; set; }
        public string UserPar { get; set; }
        public int IdTipoDatoControl { get; set; }
        public bool? Activa { get; set; }

        public virtual Importadores IdImportadoresNavigation { get; set; }
        public virtual TipoDatoControl IdTipoDatoControlNavigation { get; set; }
        public virtual ICollection<ImportacionesUserParValues> ImportacionesUserParValues { get; set; }
        public virtual ICollection<SchemaColumns> SchemaColumns { get; set; }
    }
}
