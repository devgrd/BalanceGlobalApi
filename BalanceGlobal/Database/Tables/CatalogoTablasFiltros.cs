using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class CatalogoTablasFiltros
    {
        public int IdCatalogoTablasFiltros { get; set; }
        public int IdCatalogoTablas { get; set; }
        public string TipoFiltro { get; set; }
        public string ColumnaFiltro { get; set; }
        public bool? Activa { get; set; }
        public string ColumnaDelete { get; set; }
    }
}
