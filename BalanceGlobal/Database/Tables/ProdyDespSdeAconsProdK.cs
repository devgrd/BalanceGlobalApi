using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ProdyDespSdeAconsProdK
    {
        public int IdProdyDespSdeAconsProdK { get; set; }
        public int IdPeriodos { get; set; }
        public int IdModalidadPlantas { get; set; }
        public int IdCorrientes { get; set; }
        public int IdSistemasSubsistemas { get; set; }
        public int? IdInfraestructuraPlanta { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProdyDespSdeAvariablesNum { get; set; }
        public decimal? Valor { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Corrientes IdCorrientesNavigation { get; set; }
        public virtual Infraestructuras IdInfraestructuraPlantaNavigation { get; set; }
        public virtual ModalidadPlantas IdModalidadPlantasNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
        public virtual ProdyDespSdeAvariablesNum IdProdyDespSdeAvariablesNumNavigation { get; set; }
        public virtual SistemasSubSistemas IdSistemasSubsistemasNavigation { get; set; }
    }
}
