using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class SuscripcionEventos
    {
        public int IdSuscripcionEventos { get; set; }
        public int IdEventos { get; set; }
        public int IdUsuarios { get; set; }

        public virtual Eventos IdEventosNavigation { get; set; }
        public virtual Usuarios IdUsuariosNavigation { get; set; }
    }
}
