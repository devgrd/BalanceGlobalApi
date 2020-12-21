using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class BgajustesModel : ModelBase
    {
        [Required] public int IdBgajustes { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdBgclasificacion { get; set; }
        [Required] public int IdBgtipos { get; set; }
        [Required] public int IdBgcorrientes { get; set; }
        [Required] public int IdFaena { get; set; }
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

    }
}
