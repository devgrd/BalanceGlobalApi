using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class PciacopiosOrigen
    {
        public PciacopiosOrigen()
        {
            PciacopiosCli = new HashSet<PciacopiosCli>();
        }

        public int IdPciacopiosOrigen { get; set; }
        public string Acopio { get; set; }
        public DateTime FechaOrigen { get; set; }
        public int IdSubSistemas { get; set; }
        public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual SubSistemas IdSubSistemasNavigation { get; set; }
        public virtual ICollection<PciacopiosCli> PciacopiosCli { get; set; }
    }
}
