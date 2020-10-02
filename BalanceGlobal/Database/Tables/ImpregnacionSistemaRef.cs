using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ImpregnacionSistemaRef
    {
        public int IdImpregnacionSistemaRef { get; set; }
        public int IdSubSistemas { get; set; }
        public decimal ImpregnacionTotal { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual SubSistemas IdSubSistemasNavigation { get; set; }
    }
}
