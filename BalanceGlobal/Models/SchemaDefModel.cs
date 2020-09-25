using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class SchemaDefModel : ModelBase
    {

        [Required] public int IdSchemaDef { get; set; }
        [Required] public int IdOrigenesDatos { get; set; }
        public string UniqueKeyList { get; set; }
        public string SkiprowsList { get; set; }
        [Required] public bool UsarPosicion { get; set; }
        public int? FilaNombreColumna { get; set; }

    }
}
