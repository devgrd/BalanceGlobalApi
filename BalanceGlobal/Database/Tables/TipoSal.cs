using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TipoSal
    {
        public TipoSal()
        {
            CargaPlataformas = new HashSet<CargaPlataformas>();
            DescargaPlataformas = new HashSet<DescargaPlataformas>();
            FactoresImpregnacion = new HashSet<FactoresImpregnacion>();
        }

        public int IdTipoSal { get; set; }
        public string TipoSal1 { get; set; }
        public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<CargaPlataformas> CargaPlataformas { get; set; }
        public virtual ICollection<DescargaPlataformas> DescargaPlataformas { get; set; }
        public virtual ICollection<FactoresImpregnacion> FactoresImpregnacion { get; set; }
    }
}
