using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataConceptoConsumoEnergeticoModel : ModelBase
    {
        public string Id { get; set; }
        public string Descripción { get; set; }
        public string Um { get; set; }
    }
}
