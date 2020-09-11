using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Subsistemas
    {
        public Subsistemas()
        {
            SistemasSubSistemas = new HashSet<SistemasSubSistemas>();
        }

        public int IdSubsistemas { get; set; }
        public string Subsistema { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }

        [JsonIgnore]
        public virtual ICollection<SistemasSubSistemas> SistemasSubSistemas { get; set; }
    }
}
