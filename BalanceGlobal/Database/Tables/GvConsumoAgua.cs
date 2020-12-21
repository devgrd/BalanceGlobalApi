using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvConsumoAgua
    {
        public int IdConsumoAgua { get; set; }
        public string Periodo { get; set; }
        public string CategoriasConsumoAgua { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? VolAguaM3 { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
