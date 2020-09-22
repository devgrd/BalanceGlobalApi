using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class SubsistemasEntity : EntityBase
    {

        public int IdSubsistemas { get; set; }
        public string Subsistema { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }


    }
}
