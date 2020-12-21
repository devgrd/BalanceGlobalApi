using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvDataInfraestructurasModel : ModelBase
    {
        [Required] public int IdInfraestructuras { get; set; }
        public string Infraestructura { get; set; }
        public string Descripcion { get; set; }
        public string TipoInfraestructura { get; set; }
        public string InfraestructuraPadre { get; set; }
        [Required] public bool Activa { get; set; }
    }
}
