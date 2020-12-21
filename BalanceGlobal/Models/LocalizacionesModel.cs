using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class LocalizacionesModel : ModelBase
    {
        [Required] public int IdLocalizacion { get; set; }
        public string Localizacion { get; set; }
        public string Descripcion { get; set; }
    }
}
