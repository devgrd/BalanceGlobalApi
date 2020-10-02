using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Importaciones
    {
        public Importaciones()
        {
            ImportacionesUserParValues = new HashSet<ImportacionesUserParValues>();
            MensajesImportacion = new HashSet<MensajesImportacion>();
        }

        public int IdImportaciones { get; set; }
        public int IdImportadores { get; set; }
        public DateTime Fecha { get; set; }
        public Guid? Uid { get; set; }

        public virtual Importadores IdImportadoresNavigation { get; set; }
        public virtual ICollection<ImportacionesUserParValues> ImportacionesUserParValues { get; set; }
        public virtual ICollection<MensajesImportacion> MensajesImportacion { get; set; }
    }
}
