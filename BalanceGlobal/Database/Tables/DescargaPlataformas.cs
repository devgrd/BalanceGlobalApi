using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DescargaPlataformas
    {
        public DescargaPlataformas()
        {
            DescargaInfraestructurasDestino = new HashSet<DescargaInfraestructurasDestino>();
        }

        public int IdDescargaPlataformas { get; set; }
        public DateTime Fecha { get; set; }
        public int IdPeriodos { get; set; }
        public int IdPlataforma { get; set; }
        public decimal? VolSalidaM3 { get; set; }
        public decimal? ImpregnacionPct { get; set; }
        public decimal? VolenPlataformaM3 { get; set; }
        public int IdTipoSal { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? KPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? H3b3oPct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Periodos IdPeriodosNavigation { get; set; }
        public virtual Infraestructuras IdPlataformaNavigation { get; set; }
        public virtual TipoSal IdTipoSalNavigation { get; set; }
        public virtual ICollection<DescargaInfraestructurasDestino> DescargaInfraestructurasDestino { get; set; }
    }
}
