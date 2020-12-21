using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvRefSistemasSubsistemas
    {
        public int IdSistemasSubsistemas { get; set; }
        public string Sistema { get; set; }
        public int IdSistemas { get; set; }
        public string Subsistema { get; set; }
        public int? IdSubsistemas { get; set; }
    }
}
