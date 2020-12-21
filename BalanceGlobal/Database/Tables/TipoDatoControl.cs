using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TipoDatoControl
    {
        public TipoDatoControl()
        {
            ImportadoresUserPar = new HashSet<ImportadoresUserPar>();
        }

        public int IdTipoDatoControl { get; set; }
        public string TipoDatoControl1 { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }

        public virtual ICollection<ImportadoresUserPar> ImportadoresUserPar { get; set; }
    }
}
