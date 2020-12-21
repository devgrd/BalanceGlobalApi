using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class BgclasificacionModel : ModelBase
    {

        [Required] public int IdBgclasificacion { get; set; }
        public string Clasificacion { get; set; }
        public bool? Activa { get; set; }

    }
}
