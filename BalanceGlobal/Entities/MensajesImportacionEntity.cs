using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class MensajesImportacionEntity
    {

        public int IdMensajesImportacion { get; set; }
        public int IdOrigenesDatos { get; set; }
        public int IdTipoMensaje { get; set; }
        public int? ErrorCounter { get; set; }
        public string Fila { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }

    }
}
