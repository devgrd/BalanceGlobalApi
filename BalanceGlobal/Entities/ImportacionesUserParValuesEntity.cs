using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class ImportacionesUserParValuesEntity
    {
        public int IdImportacionesUserParValues { get; set; }
        public int IdImportadoresUserPar { get; set; }
        public int IdImportaciones { get; set; }
        public string Value { get; set; }
        public DateTime Fecha { get; set; }

    }
}
