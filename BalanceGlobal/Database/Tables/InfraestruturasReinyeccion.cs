using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class InfraestruturasReinyeccion
    {
        public int IdInfraestructurasReinyeccion { get; set; }
        public int IdInfraestructuras { get; set; }
        public int IdSistemasSubsistemas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Infraestructuras IdInfraestructurasNavigation { get; set; }
        public virtual SistemasSubSistemas IdSistemasSubsistemasNavigation { get; set; }
    }
}
