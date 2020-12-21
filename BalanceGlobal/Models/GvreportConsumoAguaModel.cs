using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvreportConsumoAguaModel : ModelBase
    {
        public string Periodo { get; set; }
        public string GrupoReporte { get; set; }
        public string SuperGrupoReporte { get; set; }
        public decimal? VolAguaM3 { get; set; }
    }
}
