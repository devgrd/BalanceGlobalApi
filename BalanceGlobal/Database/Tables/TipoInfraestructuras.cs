using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TipoInfraestructuras
    {
        public TipoInfraestructuras()
        {
            Infraestructuras = new HashSet<Infraestructuras>();
        }

        public int IdTipoInfraestructuras { get; set; }
        public string TipoInfraestructura { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<Infraestructuras> Infraestructuras { get; set; }
    }
}
