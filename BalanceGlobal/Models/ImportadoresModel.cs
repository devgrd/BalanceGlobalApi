using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ImportadoresModel : ModelBase
    {

        [Required] public int IdImportadores { get; set; }
        public string Nombre { get; set; }
        public bool? Activa { get; set; }

    }
}
