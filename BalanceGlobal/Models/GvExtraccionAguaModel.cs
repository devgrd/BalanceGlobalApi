using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class GvExtraccionAguaModel : ModelBase
    {
        [Required] public int IdExtraccionAgua { get; set; }
        public string Periodo { get; set; }
        public string InfraestructuraOrigen { get; set; }
        public string InfraestructuraDestino { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? VolInicialM3 { get; set; }
        public decimal? VolFinalM3 { get; set; }
        public decimal? VolTotalDia { get; set; }
        public decimal? FlujoM3h { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
