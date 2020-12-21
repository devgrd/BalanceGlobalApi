using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataConsumoAguaModel : ModelBase
    {
        [Required] public int IdConsumoAgua { get; set; }
        public string Periodo { get; set; }
        public string CategoriasConsumoAgua { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? VolAguaM3 { get; set; }
        public string GrupoReporte { get; set; }
        public string SuperGrupoReporte { get; set; }
        public string Faena { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
    }
}
