using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class FactoresImpregnacion
    {
        public int IdFactoresImpregnacion { get; set; }
        public string IdSistema { get; set; }
        public int IdTipoSal { get; set; }
        public decimal FactorM3m2 { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual TipoSal IdTipoSalNavigation { get; set; }
    }
}
