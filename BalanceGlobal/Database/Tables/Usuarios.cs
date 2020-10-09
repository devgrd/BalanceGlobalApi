using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            SuscripcionEventos = new HashSet<SuscripcionEventos>();
            UsuariosPerfilesUsuario = new HashSet<UsuariosPerfilesUsuario>();
        }

        public int IdUsuarios { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Activo { get; set; }
        public bool? RecibeNotificacion { get; set; }
        public Guid Uid { get; set; }

        public virtual ICollection<SuscripcionEventos> SuscripcionEventos { get; set; }
        public virtual ICollection<UsuariosPerfilesUsuario> UsuariosPerfilesUsuario { get; set; }
    }
}
