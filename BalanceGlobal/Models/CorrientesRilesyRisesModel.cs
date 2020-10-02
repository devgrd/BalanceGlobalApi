using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class CorrientesRilesyRisesModel : ModelBase
    {

        [Required] public int IdCorrientesRilesyRises { get; set; }
        public string CorrientesRilesyRises1 { get; set; }
        public string Descripcion { get; set; }
        [Required] public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
