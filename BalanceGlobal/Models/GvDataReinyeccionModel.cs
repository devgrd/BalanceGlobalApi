using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataReinyeccionModel : ModelBase
    {
        [Required] public int IdReinyeccion { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string Periodo { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? EvapAreaExpuestaM3dia { get; set; }
        public decimal? EvapAreaImpM3dia { get; set; }
        public decimal? SalmueraInfiltradaM3dia { get; set; }
    }
}
