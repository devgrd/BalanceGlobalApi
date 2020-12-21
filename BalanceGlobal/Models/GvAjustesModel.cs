using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvAjustesModel : ModelBase
    {
        [Required] public int IdBgajustes { get; set; }
        public string Periodo { get; set; }
        public string Clasificacion { get; set; }
        public string Tipo { get; set; }
        public string Corriente { get; set; }
        public string Faena { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string Infraestructura { get; set; }
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
