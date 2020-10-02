using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class SchemaDef
    {
        public SchemaDef()
        {
            ImportDestino = new HashSet<ImportDestino>();
            SchemaColumns = new HashSet<SchemaColumns>();
            SchemaColumnsWarning = new HashSet<SchemaColumnsWarning>();
        }

        public int IdSchemaDef { get; set; }
        public int IdOrigenesDatos { get; set; }
        public string UniqueKeyList { get; set; }
        public string SkiprowsList { get; set; }
        public bool UsarPosicion { get; set; }
        public int? FilaNombreColumna { get; set; }
        public int? FilaInicioDatos { get; set; }

        public virtual OrigenesDatos IdOrigenesDatosNavigation { get; set; }
        public virtual ICollection<ImportDestino> ImportDestino { get; set; }
        public virtual ICollection<SchemaColumns> SchemaColumns { get; set; }
        public virtual ICollection<SchemaColumnsWarning> SchemaColumnsWarning { get; set; }
    }
}
