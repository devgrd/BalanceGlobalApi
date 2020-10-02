using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class CorrientesModel : ModelBase
    {

        [Required] public int IdCorrientes { get; set; }
        public string Corriente { get; set; }
        public string Descripcion { get; set; }
        [Required] public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
