using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class MensajesImportacionTempModel : ModelBase
    {
        [Required] public int IdMensajesImportacion { get; set; }
        [Required] public int IdImportaciones { get; set; }
        [Required] public int IdTipoMensaje { get; set; }
        public string Fila { get; set; }
        public string Mensaje { get; set; }
        public DateTime? Fecha { get; set; }

    }
}
