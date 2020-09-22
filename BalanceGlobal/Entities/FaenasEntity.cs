using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public class FaenasEntity : EntityBase
    {
        public int IdFaenas { get; set; }
        public string Faena { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
    }
}
