using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataReinyeccionDatos1Model : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public double? EvapAreaExpuestaM3dia { get; set; }
        public double? EvapAreaImpM3dia { get; set; }
        public double? SalmueraInfiltradaM3dia { get; set; }
        public string Sistema { get; set; }
    }
}
