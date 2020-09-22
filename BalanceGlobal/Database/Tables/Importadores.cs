using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Importadores
    {
        public Importadores()
        {
            Importaciones = new HashSet<Importaciones>();
            OrigenesDatos = new HashSet<OrigenesDatos>();
        }

        public int IdImportadores { get; set; }
        public string Nombre { get; set; }
        public bool? Activa { get; set; }

        public virtual ICollection<Importaciones> Importaciones { get; set; }
        public virtual ICollection<OrigenesDatos> OrigenesDatos { get; set; }
    }
}
