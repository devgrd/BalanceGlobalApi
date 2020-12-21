using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataInfraestructuras
    {
        public int IdInfraestructuras { get; set; }
        public string Infraestructura { get; set; }
        public string Descripcion { get; set; }
        public string TipoInfraestructura { get; set; }
        public string InfraestructuraPadre { get; set; }
        public bool Activa { get; set; }
    }
}
