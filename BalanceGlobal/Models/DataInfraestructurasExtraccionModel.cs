using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataInfraestructurasExtraccionModel : ModelBase
    {
        public string Infraestructura { get; set; }
        public string TipoInfraestructura { get; set; }
        public string InfraestructuraPadre { get; set; }
    }
}
