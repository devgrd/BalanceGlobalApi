using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class UsuariosPerfilesUsuario
    {
        public int IdUsuariosPerfilesUsuario { get; set; }
        public int IdPerfilUsuario { get; set; }
        public int IdUsuarios { get; set; }

        public virtual PerfilesUsuario IdPerfilUsuarioNavigation { get; set; }
        public virtual Usuarios IdUsuariosNavigation { get; set; }
    }
}
