using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class TipoInfraestructurasModel : ModelBase
    {

        [Required] public int IdTipoInfraestructuras { get; set; }
        public string TipoInfraestructura { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
