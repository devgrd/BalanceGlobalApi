using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ImportacionesUserParValues
    {
        public int IdImportacionesUserParValues { get; set; }
        public int IdImportadoresUserPar { get; set; }
        public int IdImportaciones { get; set; }
        public string Value { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Importaciones IdImportacionesNavigation { get; set; }
    }
}
