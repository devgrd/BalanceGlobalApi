using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class InfraestructurasModel : ModelBase
    {

        [Required] public int IdInfraestructuras { get; set; }
        public string Infraestructura { get; set; }
        public string Descripcion { get; set; }
        [Required] public int IdTipoInfraestructuras { get; set; }
        public int? IdInfraestructuraPadre { get; set; }
        public bool? Activa { get; set; }
        public bool? ReportarAgrupada { get; set; }

    }
}
