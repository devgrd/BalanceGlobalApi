using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ExtraccionAguaModel : ModelBase
    {
        [Required] public int IdExtraccionAgua { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdInfraestructuraOrigen { get; set; }
        [Required] public int IdInfraestructuraDestino { get; set; }
        [Required] public DateTime Fecha { get; set; }
        public decimal? VolInicialM3 { get; set; }
        public decimal? VolFinalM3 { get; set; }
        public decimal? VolTotalDia { get; set; }
        public decimal? FlujoM3h { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
