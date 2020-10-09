using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Eventos
    {
        public Eventos()
        {
            SuscripcionEventos = new HashSet<SuscripcionEventos>();
        }

        public int IdEventos { get; set; }
        public string Evento { get; set; }
        public string Descripcion { get; set; }
        public bool Acivo { get; set; }

        public virtual ICollection<SuscripcionEventos> SuscripcionEventos { get; set; }
    }
}
