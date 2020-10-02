using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ExtraccionAgua
    {
        public int IdExtraccionAgua { get; set; }
        public int IdPeriodos { get; set; }
        public int IdInfraestructuraOrigen { get; set; }
        public int IdInfraestructuraDestino { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? VolInicialM3 { get; set; }
        public decimal? VolFinalM3 { get; set; }
        public decimal? VolTotalDia { get; set; }
        public decimal? FlujoM3h { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Infraestructuras IdInfraestructuraDestinoNavigation { get; set; }
        public virtual Infraestructuras IdInfraestructuraOrigenNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
    }
}
