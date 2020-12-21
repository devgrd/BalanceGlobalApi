using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataProdyDespSdeAconsProdK
    {
        public int IdProdyDespSdeAconsProdK { get; set; }
        public string Periodo { get; set; }
        public string Sistema { get; set; }
        public string ModalidadPlanta { get; set; }
        public string Corriente { get; set; }
        public string Subsistema { get; set; }
        public string Infraestructura { get; set; }
        public DateTime Fecha { get; set; }
        public string Variable { get; set; }
        public decimal? Valor { get; set; }
    }
}
