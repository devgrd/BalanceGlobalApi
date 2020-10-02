using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ConsLitioLiCo3mensual
    {
        public int IdConsLitioLiCo3mensual { get; set; }
        public int IdSistemasSubSistemas { get; set; }
        public int IdPeriodos { get; set; }
        public int IdCorrienteLi2Co3 { get; set; }
        public decimal? Li2Co3FrescaTon { get; set; }
        public decimal? Li2Co3TotalTon { get; set; }
        public decimal? CarbonatoTon { get; set; }
        public decimal? LitioFrescoTon { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual CorrienteLi2Co3 IdCorrienteLi2Co3Navigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
        public virtual SistemasSubSistemas IdSistemasSubSistemasNavigation { get; set; }
    }
}
