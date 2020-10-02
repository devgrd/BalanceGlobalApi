using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class CorrientesRilesyRises
    {
        public CorrientesRilesyRises()
        {
            ConsRilesyRises = new HashSet<ConsRilesyRises>();
        }

        public int IdCorrientesRilesyRises { get; set; }
        public string CorrientesRilesyRises1 { get; set; }
        public string Descripcion { get; set; }
        public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<ConsRilesyRises> ConsRilesyRises { get; set; }
    }
}
