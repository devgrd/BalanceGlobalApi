using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class PeriodosEntity : EntityBase
    {
        public int IdPeriodos { get; set; }
        public string Periodo { get; set; }
        public int? IdTipoPeriodo { get; set; }
        public bool? Activa { get; set; }

    }
}
