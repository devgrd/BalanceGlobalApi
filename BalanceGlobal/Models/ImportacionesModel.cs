using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ImportacionesModel : ModelBase
    {

        [Required] public int IdImportaciones { get; set; }
        [Required] public int IdImportadores { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public Guid? Uid { get; set; }

    }
}
