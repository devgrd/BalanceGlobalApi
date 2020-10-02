using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TiposInventario
    {
        public TiposInventario()
        {
            InventariosAtacama = new HashSet<InventariosAtacama>();
        }

        public int IdTiposInventario { get; set; }
        public string TipoInventario { get; set; }
        public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<InventariosAtacama> InventariosAtacama { get; set; }
    }
}
