using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class CatalogoTablasFiltrosModel : ModelBase
    {
        [Required] public int IdCatalogoTablasFiltros { get; set; }
        [Required] public int IdCatalogoTablas { get; set; }
        public string TipoFiltro { get; set; }
        public string ColumnaFiltro { get; set; }
        public bool? Activa { get; set; }
        public string ColumnaDelete { get; set; }
    }
}
