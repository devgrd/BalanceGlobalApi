using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TipoOrigen
    {
        public TipoOrigen()
        {
            OrigenesDatos = new HashSet<OrigenesDatos>();
        }

        public int IdTipoOrigen { get; set; }
        public string TipoOrigen1 { get; set; }

        public virtual ICollection<OrigenesDatos> OrigenesDatos { get; set; }
    }
}
