using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class TraspasosPlataformasModel : ModelBase
    {

        [Required] public int IdTraspasosPlataformas { get; set; }
        [Required] public int IdPlataforma { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? VolAguaM3 { get; set; }
        public decimal? VolSalmueraM3 { get; set; }
        public decimal? VolSalM3 { get; set; }
        public int? IdInfraestructuraDestino { get; set; }
        public decimal? ImpregnacionInicial { get; set; }
        public decimal? LitioInicialPct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
