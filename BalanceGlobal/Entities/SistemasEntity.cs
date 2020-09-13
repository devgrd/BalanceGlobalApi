using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class Sistemas
    {

        public int IdSistemas { get; set; }
        public string Sistema { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }

    }
}
