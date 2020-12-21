using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class CatalogoVistas
    {
        public int IdCatalogoVistas { get; set; }
        public string Vista { get; set; }
        public string Descripcion { get; set; }
        public string Origen { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
