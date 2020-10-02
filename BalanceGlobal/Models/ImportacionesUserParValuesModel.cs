using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ImportacionesUserParValuesModel : ModelBase
    {
        [Required] public int IdImportacionesUserParValues { get; set; }
        [Required] public int IdImportadoresUserPar { get; set; }
        [Required] public int IdImportaciones { get; set; }
        public string Value { get; set; }
        [Required] public DateTime Fecha { get; set; }

    }
}
