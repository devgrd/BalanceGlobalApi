using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvTasaEvaporacion
    {
        public int IdTasaEvaporacion { get; set; }
        public string Sistema { get; set; }
        public string Periodo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? TasaEvaporacionMmdia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
