using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TipoHeader
    {
        public TipoHeader()
        {
            OrigenesDatos = new HashSet<OrigenesDatos>();
        }

        public int IdTipoHeader { get; set; }
        public string TipoHeader1 { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }

        public virtual ICollection<OrigenesDatos> OrigenesDatos { get; set; }
    }
}
