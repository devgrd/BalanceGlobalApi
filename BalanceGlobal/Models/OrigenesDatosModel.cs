using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class OrigenesDatosModel : ModelBase
    {

        [Required] public int IdOrigenesDatos { get; set; }
        [Required] public int IdImportadores { get; set; }
        public string OrigenDatos { get; set; }
        public string Tab { get; set; }
        [Required] public int IdTipoOrigen { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        [Required] public int IdTipoHeader { get; set; }
        public bool? Activa { get; set; }

    }
}
