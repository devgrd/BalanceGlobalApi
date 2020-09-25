using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class TransSistemasCosechas
    {
        public int IdTransSistemasCosechas { get; set; }
        public string SistemaOrigen { get; set; }
        public string SubsistemaOrigen { get; set; }
        public int IdSistemasSubsistemas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
