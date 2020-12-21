using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvRefCategoriaConsumoAgua
    {
        public int IdCategoriaConsumoAgua { get; set; }
        public string CategoriasConsumoAgua { get; set; }
        public string Descripcion { get; set; }
        public string Faena { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public bool Activo { get; set; }
        public string GrupoReporte { get; set; }
        public string SuperGrupoReporte { get; set; }
    }
}
