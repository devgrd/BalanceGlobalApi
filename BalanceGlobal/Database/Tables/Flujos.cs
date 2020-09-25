using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Flujos
    {
        public int IdFlujos { get; set; }
        public int IdPeriodos { get; set; }
        public int IdSistemasSubsistemas { get; set; }
        public int IdBombas { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? TotalizadorM3 { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
