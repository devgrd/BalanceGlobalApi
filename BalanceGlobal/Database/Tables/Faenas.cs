using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Faenas
    {
        public Faenas()
        {
            FaenasSistemas = new HashSet<FaenasSistemas>();
        }

        public int IdFaenas { get; set; }
        public string Faena { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }

        public virtual ICollection<FaenasSistemas> FaenasSistemas { get; set; }
    }
}
