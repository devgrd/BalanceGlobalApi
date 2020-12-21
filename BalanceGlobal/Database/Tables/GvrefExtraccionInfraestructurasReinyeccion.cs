using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvrefExtraccionInfraestructurasReinyeccion
    {
        public int IdInfraestructurasReinyeccion { get; set; }
        public string Infraestructura { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
    }
}
