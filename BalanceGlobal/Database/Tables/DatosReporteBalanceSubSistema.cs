using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DatosReporteBalanceSubSistema
    {
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string Subtipo { get; set; }
        public string Detalle { get; set; }
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string SubSistema { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? LceTon { get; set; }
        public decimal? MgTon { get; set; }
        public decimal? So4Ton { get; set; }
        public decimal? CaTon { get; set; }
        public decimal? ClTon { get; set; }
        public decimal? KTon { get; set; }
        public decimal? NaTon { get; set; }
        public decimal? H3bo3Ton { get; set; }
        public decimal? AguaTon { get; set; }
        public string Vista { get; set; }
    }
}
