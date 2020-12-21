using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Bgclasificacion
    {
        public Bgclasificacion()
        {
            Bgajustes = new HashSet<Bgajustes>();
        }

        public int IdBgclasificacion { get; set; }
        public string Clasificacion { get; set; }
        public bool? Activa { get; set; }

        public virtual ICollection<Bgajustes> Bgajustes { get; set; }
    }
}
