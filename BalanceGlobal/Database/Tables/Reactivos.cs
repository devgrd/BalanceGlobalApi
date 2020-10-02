using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Reactivos
    {
        public Reactivos()
        {
            ConsReactivos = new HashSet<ConsReactivos>();
        }

        public int IdReactivos { get; set; }
        public string Reactivo { get; set; }
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<ConsReactivos> ConsReactivos { get; set; }
    }
}
