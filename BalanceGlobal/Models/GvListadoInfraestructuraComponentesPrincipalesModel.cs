using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvListadoInfraestructuraComponentesPrincipalesModel : ModelBase
    {
        public int? IdInfraestructuras { get; set; }
        public string Infraestructura { get; set; }
        public int? IdInfraestructuraPrincipal { get; set; }
        public string InfraestructuraPrincipal { get; set; }
        public int? Nivel { get; set; }
    }
}
