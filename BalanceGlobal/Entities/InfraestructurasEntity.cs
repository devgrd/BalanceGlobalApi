using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class Infraestructuras
    {

        public int IdInfraestructuras { get; set; }
        public string Infraestructura { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoInfraestructuras { get; set; }
        public int? IdInfraestructuraPadre { get; set; }
        public bool? Activa { get; set; }
        public bool? ReportarAgrupada { get; set; }

    }
}
