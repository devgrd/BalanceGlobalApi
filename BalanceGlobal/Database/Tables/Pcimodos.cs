using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Pcimodos
    {
        public int IdPcimodos { get; set; }
        public int IdModalidadPci { get; set; }
        public int IdCorrientePci { get; set; }
        public int IdInfrestructuras { get; set; }
        public int IdTipoPci { get; set; }
        public int IdPeriodos { get; set; }
        public int IdSistemasSubsistemas { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? KPct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? MasaLceTon { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual CorrientePci IdCorrientePciNavigation { get; set; }
        public virtual Infraestructuras IdInfrestructurasNavigation { get; set; }
        public virtual ModalidadPci IdModalidadPciNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
        public virtual SistemasSubSistemas IdSistemasSubsistemasNavigation { get; set; }
        public virtual TipoPci IdTipoPciNavigation { get; set; }
    }
}
