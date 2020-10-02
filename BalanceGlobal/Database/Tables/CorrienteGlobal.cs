using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class CorrienteGlobal
    {
        public CorrienteGlobal()
        {
            ConsLi2Co3 = new HashSet<ConsLi2Co3>();
        }

        public int IdCorrienteGlobal { get; set; }
        public string CorrienteGlobal1 { get; set; }
        public string Descipcion { get; set; }
        public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<ConsLi2Co3> ConsLi2Co3 { get; set; }
    }
}
