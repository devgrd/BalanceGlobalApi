using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvTraspasosPlataformasModel : ModelBase
    {
        [Required] public int IdTraspasosPlataformas { get; set; }
        public string Plataforma { get; set; }
        public string Periodo { get; set; }
        [Required] public DateTime Fecha { get; set; }
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
