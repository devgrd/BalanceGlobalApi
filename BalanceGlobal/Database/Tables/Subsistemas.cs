using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class SubSistemas
    {
        public SubSistemas()
        {
            SistemasSubSistemas = new HashSet<SistemasSubSistemas>();
        }

        public int IdSubSistemas { get; set; }
        public string SubSistema { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<SistemasSubSistemas> SistemasSubSistemas { get; set; }
    }
}
