using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class UsuariosPerfilesUsuarioModel : ModelBase
    {
        [Required] public int IdUsuariosPerfilesUsuario { get; set; }
        [Required] public int IdPerfilUsuario { get; set; }
        [Required] public int IdUsuarios { get; set; }

    }
}
