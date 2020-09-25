using System.ComponentModel.DataAnnotations;
using System;

namespace BalanceGlobal.Models
{
    public class TipoInfraestructurasModel : ModelBase
    {
        [Required] public int IdTipoInfraestructuras { get; set; }
        public string TipoInfraestructuras { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
