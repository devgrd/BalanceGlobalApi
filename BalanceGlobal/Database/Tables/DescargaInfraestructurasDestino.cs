using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DescargaInfraestructurasDestino
    {
        public int IdDescargaInfraestructurasDestino { get; set; }
        public int IdInfraestructura { get; set; }
        public int IdDescargaPlataformas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual DescargaPlataformas IdDescargaPlataformasNavigation { get; set; }
        public virtual Infraestructuras IdInfraestructuraNavigation { get; set; }
    }
}
