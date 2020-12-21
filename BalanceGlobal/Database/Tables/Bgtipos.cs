using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Bgtipos
    {
        public Bgtipos()
        {
            Bgajustes = new HashSet<Bgajustes>();
        }

        public int IdBgtipos { get; set; }
        public string Tipo { get; set; }
        public bool? Activa { get; set; }

        public virtual ICollection<Bgajustes> Bgajustes { get; set; }
    }
}
