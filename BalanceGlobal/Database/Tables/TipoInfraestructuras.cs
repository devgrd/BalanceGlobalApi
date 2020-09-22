using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TipoInfraestructuras
    {
        public int IdTipoInfraestructuras { get; set; }
        public string TipoInfraestructuras1 { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
