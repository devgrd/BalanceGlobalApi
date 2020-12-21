using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvCkmopIivolaPorteo
    {
        public int IdCkmopIivolaPorteo { get; set; }
        public string Periodo { get; set; }
        public string Infraestructura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? VolumenM3dia { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
