using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class SistemasSubSistemas
    {
        public int IdSistemasSubsistemas { get; set; }
        public int IdSistemas { get; set; }
        public int? IdSubsistemas { get; set; }

    }
}
