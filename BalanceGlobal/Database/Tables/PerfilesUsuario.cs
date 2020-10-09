using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class PerfilesUsuario
    {
        public PerfilesUsuario()
        {
            DetallePerfil = new HashSet<DetallePerfil>();
            UsuariosPerfilesUsuario = new HashSet<UsuariosPerfilesUsuario>();
        }

        public int IdPerfilUsuario { get; set; }
        public string NombrePerfilUsuario { get; set; }
        public string DescripcionPerfiles { get; set; }

        public virtual ICollection<DetallePerfil> DetallePerfil { get; set; }
        public virtual ICollection<UsuariosPerfilesUsuario> UsuariosPerfilesUsuario { get; set; }
    }
}
