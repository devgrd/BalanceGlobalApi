using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class PciacopiosCli
    {
        public int IdPciacopiosCli { get; set; }
        public int IdPciacopiosOrigen { get; set; }
        public int IdPeriodos { get; set; }
        public decimal? VolumenM3 { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        public int Prioridad { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual PciacopiosOrigen IdPciacopiosOrigenNavigation { get; set; }
        public virtual Periodos IdPeriodosNavigation { get; set; }
    }
}
