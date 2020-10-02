using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TraspasosPlataformas
    {
        public TraspasosPlataformas()
        {
            OrigenesTraspasoPlataformas = new HashSet<OrigenesTraspasoPlataformas>();
        }

        public int IdTraspasosPlataformas { get; set; }
        public int IdPlataforma { get; set; }
        public int IdPeriodos { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? VolAguaM3 { get; set; }
        public decimal? VolSalmueraM3 { get; set; }
        public decimal? VolSalM3 { get; set; }
        public int? IdInfraestructuraDestino { get; set; }
        public decimal? ImpregnacionInicial { get; set; }
        public decimal? LitioInicialPct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Infraestructuras IdInfraestructuraDestinoNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
        public virtual Infraestructuras IdPlataformaNavigation { get; set; }
        public virtual ICollection<OrigenesTraspasoPlataformas> OrigenesTraspasoPlataformas { get; set; }
    }
}
