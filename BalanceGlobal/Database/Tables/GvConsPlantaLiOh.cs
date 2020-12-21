using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvConsPlantaLiOh
    {
        public int IdConsPlantaLiOh { get; set; }
        public string Periodo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Li2Co3Pct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
