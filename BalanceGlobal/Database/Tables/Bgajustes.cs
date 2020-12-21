using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Bgajustes
    {
        public int IdBgajustes { get; set; }
        public int IdPeriodos { get; set; }
        public int IdBgclasificacion { get; set; }
        public int IdBgtipos { get; set; }
        public int IdBgcorrientes { get; set; }
        public int IdFaena { get; set; }
        public int? IdSistemasSubSitemas { get; set; }
        public int? IdInfraestructuras { get; set; }
        public decimal? MasaTon { get; set; }
        public decimal? LceTon { get; set; }
        public decimal? KTon { get; set; }
        public decimal? MgTon { get; set; }
        public decimal? So4Ton { get; set; }
        public decimal? CaTon { get; set; }
        public decimal? ClTon { get; set; }
        public decimal? NaTon { get; set; }
        public decimal? H3bo3Ton { get; set; }
        public decimal? H2oTon { get; set; }
        public bool? Estado { get; set; }
        public string Comentario { get; set; }

        public virtual Bgclasificacion IdBgclasificacionNavigation { get; set; }
        public virtual Bgcorrientes IdBgcorrientesNavigation { get; set; }
        public virtual Bgtipos IdBgtiposNavigation { get; set; }
        public virtual Faenas IdFaenaNavigation { get; set; }
        public virtual Infraestructuras IdInfraestructurasNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
        public virtual SistemasSubSistemas IdSistemasSubSitemasNavigation { get; set; }
    }
}
