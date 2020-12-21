using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvReportTraspasoSalidaMopiicarnalitaAsperiodoOperacionalModel : ModelBase
    {
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string SubTipo { get; set; }
        public string Detalle { get; set; }
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string SubSistema { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? LceTon { get; set; }
        public int? MgTon { get; set; }
        public int? So4Ton { get; set; }
        public int? CaTon { get; set; }
        public int? ClTon { get; set; }
        public decimal? KTon { get; set; }
        public int? NaTon { get; set; }
        public int? H3bo3Ton { get; set; }
        public int? AguaTon { get; set; }
    }
}
