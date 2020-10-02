using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class OrigenesTraspasoPlataformas
    {
        public int IdIdOrigenesTraspasoPlataformas { get; set; }
        public int IdInfraestructuras { get; set; }
        public int IdTraspasosPlataformas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Infraestructuras IdInfraestructurasNavigation { get; set; }
        public virtual TraspasosPlataformas IdTraspasosPlataformasNavigation { get; set; }
    }
}
