using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Sistemas
    {
        public Sistemas()
        {
            SistemasSubSistemas = new HashSet<SistemasSubSistemas>();
        }

        public int IdSistemas { get; set; }
        public string Sistema { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }

        public virtual ICollection<SistemasSubSistemas> SistemasSubSistemas { get; set; }
    }
}
