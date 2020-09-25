using System.ComponentModel.DataAnnotations;
using System;

namespace BalanceGlobal.Models
{
    public class BombasModel : ModelBase
    {
        [Required] public int IdBombas { get; set; }
        public string Bomba { get; set; }
        public string Descripcion { get; set; }
        [Required] public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
