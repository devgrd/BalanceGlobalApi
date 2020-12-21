using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Bgcorrientes
    {
        public Bgcorrientes()
        {
            Bgajustes = new HashSet<Bgajustes>();
        }

        public int IdBgcorrientes { get; set; }
        public string Bgcorriente { get; set; }
        public bool? Activa { get; set; }

        public virtual ICollection<Bgajustes> Bgajustes { get; set; }
    }
}
