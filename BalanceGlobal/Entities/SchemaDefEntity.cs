using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class SchemaDefEntity
    {
        public int IdSchemaDef { get; set; }
        public int IdOrigenesDatos { get; set; }
        public string UniqueKeyList { get; set; }
        public string SkiprowsList { get; set; }
        public bool UsarPosicion { get; set; }
        public int? FilaNombreColumna { get; set; }
    }
}
