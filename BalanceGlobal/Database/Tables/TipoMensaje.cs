using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TipoMensaje
    {
        public TipoMensaje()
        {
            MensajesImportacion = new HashSet<MensajesImportacion>();
            MensajesImportacionTemp = new HashSet<MensajesImportacionTemp>();
        }

        public int IdTipoMensaje { get; set; }
        public string TipoMensaje1 { get; set; }

        public virtual ICollection<MensajesImportacion> MensajesImportacion { get; set; }
        public virtual ICollection<MensajesImportacionTemp> MensajesImportacionTemp { get; set; }
    }
}
