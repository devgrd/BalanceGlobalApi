using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class SistemasModel : ModelBase
    {

        [Required] public int IdSistemas { get; set; }
        public string Sistema { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }

    }
}
