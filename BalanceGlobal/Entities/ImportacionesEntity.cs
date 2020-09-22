using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class ImportacionesEntity
    {
        public int IdImportaciones { get; set; }
        public int IdImportadores { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdMensagesImportacion { get; set; }
    }
}
