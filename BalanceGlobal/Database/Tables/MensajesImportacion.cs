using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class MensajesImportacion
    {
        public MensajesImportacion()
        {
            Importaciones = new HashSet<Importaciones>();
        }

        public int IdMensajesImportacion { get; set; }
        public int IdOrigenesDatos { get; set; }
        public int IdTipoMensaje { get; set; }
        public int? ErrorCounter { get; set; }
        public string Fila { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }

        public virtual OrigenesDatos IdOrigenesDatosNavigation { get; set; }
        public virtual ICollection<Importaciones> Importaciones { get; set; }
    }
}
