using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Infraestructuras
    {
        public Infraestructuras()
        {
            InverseIdInfraestructuraPadreNavigation = new HashSet<Infraestructuras>();
        }

        public int IdInfraestructuras { get; set; }
        public string Infraestructura { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoInfraestructuras { get; set; }
        public int? IdInfraestructuraPadre { get; set; }
        public bool? Activa { get; set; }
        public bool? ReportarAgrupada { get; set; }

        public virtual Infraestructuras IdInfraestructuraPadreNavigation { get; set; }
        public virtual ICollection<Infraestructuras> InverseIdInfraestructuraPadreNavigation { get; set; }
    }
}
