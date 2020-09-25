using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class FaenasModel : ModelBase
    {

        [Required] public int IdFaenas { get; set; }
        public string Faena { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }

    }
}
