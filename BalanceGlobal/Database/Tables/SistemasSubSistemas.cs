using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class SistemasSubSistemas
    {
        public int IdSistemasSubSistemas { get; set; }
        public int IdSistemas { get; set; }
        public int? IdSubSistemas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual SubSistemas IdSubSistemasNavigation { get; set; }
    }
}
