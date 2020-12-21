using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataPodCarmenDatosIgs2Model : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string Medicion { get; set; }
        public string Value { get; set; }
        public string Sistema { get; set; }
        public string Corriente { get; set; }
    }
}
