using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DatosEnListaModel : ModelBase
    {

        [Required] public int IdDatosEnLista { get; set; }
        public string DatosEnLista1 { get; set; }
        public string Lista { get; set; }

    }
}
