using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ImportadoresUserParModel : ModelBase
    {

        [Required] public int IdImportadoresUserPar { get; set; }
        [Required] public int IdImportadores { get; set; }
        public string UserPar { get; set; }
        [Required] public int IdTipoDatoControl { get; set; }
        public bool? Activa { get; set; }


    }
}
