using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class SubSistemas
    {
        public SubSistemas()
        {
            ImpregnacionSistemaRef = new HashSet<ImpregnacionSistemaRef>();
            PciacopiosOrigen = new HashSet<PciacopiosOrigen>();
            SistemasSubSistemas = new HashSet<SistemasSubSistemas>();
        }

        public int IdSubSistemas { get; set; }
        public string SubSistema { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<ImpregnacionSistemaRef> ImpregnacionSistemaRef { get; set; }
        public virtual ICollection<PciacopiosOrigen> PciacopiosOrigen { get; set; }
        public virtual ICollection<SistemasSubSistemas> SistemasSubSistemas { get; set; }
    }
}
