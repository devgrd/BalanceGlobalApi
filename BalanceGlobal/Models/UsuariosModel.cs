using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class UsuariosModel : ModelBase
    {

        [Required] public int IdUsuarios { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required] public bool Activo { get; set; }
        public bool? RecibeNotificacion { get; set; }
        public Guid Uid { get; set; }

    }
}
