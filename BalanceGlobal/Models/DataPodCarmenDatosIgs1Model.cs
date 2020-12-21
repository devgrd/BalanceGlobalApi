using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataPodCarmenDatosIgs1Model : ModelBase
    {
        public DateTime? Fecha { get; set; }
        public string Reactivo { get; set; }
        public string Value { get; set; }
        public string Sistema { get; set; }
        public string SubSistema { get; set; }
        public string Unidad { get; set; }
    }
}
