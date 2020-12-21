using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataCorreccionesAjustesModel : ModelBase
    {
        public string Buscador { get; set; }
        public DateTime? Periodo { get; set; }
        public string Clasificación { get; set; }
        public string Tipo { get; set; }
        public string Corrientes { get; set; }
        public string Faena { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string Poza { get; set; }
        public double? MasaTon { get; set; }
        public double? LceTon { get; set; }
        public double? KTon { get; set; }
        public double? MgTon { get; set; }
        public double? So4Ton { get; set; }
        public double? CaTon { get; set; }
        public double? ClTon { get; set; }
        public double? NaTon { get; set; }
        public double? H3bo3Ton { get; set; }
        public double? H2oTon { get; set; }
        public double? Estado { get; set; }
        public double? Comentario { get; set; }
    }
}
