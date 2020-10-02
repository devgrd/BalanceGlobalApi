using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Permeabilidad
    {
        public int IdPermeabilidad { get; set; }
        public int IdSistemasSubsistemas { get; set; }
        public decimal? PermeabilidadM3m2dia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual SistemasSubSistemas IdSistemasSubsistemasNavigation { get; set; }
    }
}
