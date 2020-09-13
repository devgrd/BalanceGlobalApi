using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class TransSistemasCosechas
    {
        public int IdTransSistemasCosechas { get; set; }
        public string SistemaOrigen { get; set; }
        public string SubsistemaOrigen { get; set; }
        public int IdSistemasSubsistemas { get; set; }
    }
}
