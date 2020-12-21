using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataPciModos
    {
        public DateTime? Fecha { get; set; }
        public string Planta { get; set; }
        public double? Valor { get; set; }
        public string Corriente { get; set; }
        public string Tipo { get; set; }
        public string Variable { get; set; }
        public string Modo { get; set; }
    }
}
