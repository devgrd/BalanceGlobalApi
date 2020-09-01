using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Periodos
    {
        public Periodos()
        {
            Porteos = new HashSet<Porteos>();
        }

        public int IdPeriodos { get; set; }
        public string Periodo { get; set; }
        public int? IdTipoPeriodo { get; set; }
        public bool? Activa { get; set; }

        public virtual ICollection<Porteos> Porteos { get; set; }
    }
}
