using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataCategoriasConsumoModel : ModelBase
    {
        public string Faena { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string CategoriaConsumo { get; set; }
    }
}
