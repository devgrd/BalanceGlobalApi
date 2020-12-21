using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataConsReactivos
    {
        public int IdConsReactivos { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string Periodo { get; set; }
        public DateTime Fecha { get; set; }
        public string Reactivo { get; set; }
        public string Unidad { get; set; }
        public decimal? Valor { get; set; }
    }
}
