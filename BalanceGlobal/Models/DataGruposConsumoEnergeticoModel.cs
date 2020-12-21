using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataGruposConsumoEnergeticoModel : ModelBase
    {
        public string Id { get; set; }
        public string Descripción { get; set; }
    }
}
