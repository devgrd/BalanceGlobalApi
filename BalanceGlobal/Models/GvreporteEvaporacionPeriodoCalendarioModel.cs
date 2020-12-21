using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvreporteEvaporacionPeriodoCalendarioModel : ModelBase
    {
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string SubSistema { get; set; }
        public decimal? Evaporacion { get; set; }
    }
}
