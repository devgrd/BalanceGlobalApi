using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class PerfilesUsuarioModel : ModelBase
    {

        [Required] public int IdPerfilUsuario { get; set; }
        public string NombrePerfilUsuario { get; set; }
        public string DescripcionPerfiles { get; set; }

    }
}
