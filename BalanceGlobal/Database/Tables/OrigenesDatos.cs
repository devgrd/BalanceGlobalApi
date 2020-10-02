using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class OrigenesDatos
    {
        public OrigenesDatos()
        {
            SchemaDef = new HashSet<SchemaDef>();
        }

        public int IdOrigenesDatos { get; set; }
        public int IdImportadores { get; set; }
        public string OrigenDatos { get; set; }
        public string Tab { get; set; }
        public int IdTipoOrigen { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int IdTipoHeader { get; set; }
        public bool? Activa { get; set; }

        public virtual Importadores IdImportadoresNavigation { get; set; }
        public virtual ICollection<SchemaDef> SchemaDef { get; set; }
    }
}
