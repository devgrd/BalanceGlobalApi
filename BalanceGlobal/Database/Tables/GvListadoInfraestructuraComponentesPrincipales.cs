using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvListadoInfraestructuraComponentesPrincipales
    {
        public int? IdInfraestructuras { get; set; }
        public string Infraestructura { get; set; }
        public int? IdInfraestructuraPrincipal { get; set; }
        public string InfraestructuraPrincipal { get; set; }
        public int? Nivel { get; set; }
    }
}
