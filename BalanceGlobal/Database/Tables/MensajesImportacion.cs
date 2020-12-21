using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class MensajesImportacion
    {
        public int IdMensajesImportacion { get; set; }
        public int IdImportaciones { get; set; }
        public int IdTipoMensaje { get; set; }
        public int? ErrorCounter { get; set; }
        public string Fila { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Importaciones IdImportacionesNavigation { get; set; }
        public virtual TipoMensaje IdTipoMensajeNavigation { get; set; }
    }
}
