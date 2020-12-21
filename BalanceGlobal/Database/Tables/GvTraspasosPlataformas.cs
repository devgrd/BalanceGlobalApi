using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvTraspasosPlataformas
    {
        public int IdTraspasosPlataformas { get; set; }
        public string Plataforma { get; set; }
        public string Periodo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? VolAguaM3 { get; set; }
        public decimal? VolSalmueraM3 { get; set; }
        public decimal? VolSalM3 { get; set; }
        public string InfraestructuraDestino { get; set; }
        public decimal? ImpregnacionInicial { get; set; }
        public decimal? LitioInicialPct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
