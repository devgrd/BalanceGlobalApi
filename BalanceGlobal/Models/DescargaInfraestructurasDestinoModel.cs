using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DescargaInfraestructurasDestinoModel : ModelBase
    {
        [Required] public int IdDescargaInfraestructurasDestino { get; set; }
        [Required] public int IdInfraestructura { get; set; }
        [Required] public int IdDescargaPlataformas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
