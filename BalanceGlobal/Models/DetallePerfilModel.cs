using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DetallePerfilModel : ModelBase
    {
        [Required] public int IdDetallePerfil { get; set; }
        [Required] public int IdWorkflowItem { get; set; }
        [Required] public int IdPerfilUsuario { get; set; }
        [Required] public bool SoloLectura { get; set; }

    }
}
