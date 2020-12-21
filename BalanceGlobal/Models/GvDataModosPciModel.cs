using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataModosPciModel : ModelBase
    {
        [Required] public int IdPcimodos { get; set; }
        public string ModalidadPci { get; set; }
        public string CorrientePci { get; set; }
        public string Infraestructura { get; set; }
        public string TipoPci { get; set; }
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? KPct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? MasaLceTon { get; set; }
    }
}
