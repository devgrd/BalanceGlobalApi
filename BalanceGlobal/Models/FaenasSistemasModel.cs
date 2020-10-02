using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class FaenasSistemasModel : ModelBase
    {
        [Required] public int IdFaenasSistemas { get; set; }
        [Required] public int IdFaenas { get; set; }
        [Required] public int IdSistemas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
