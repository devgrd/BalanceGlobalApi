using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvrefExtraccionInfraestructurasReinyeccionModel : ModelBase
    {
        [Required] public int IdInfraestructurasReinyeccion { get; set; }
        public string Infraestructura { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
    }
}
