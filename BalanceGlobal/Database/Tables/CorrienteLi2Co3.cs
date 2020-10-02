using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class CorrienteLi2Co3
    {
        public CorrienteLi2Co3()
        {
            ConsLi2Co3 = new HashSet<ConsLi2Co3>();
            ConsLitioLiCo3mensual = new HashSet<ConsLitioLiCo3mensual>();
        }

        public int IdCorrienteLi2Co3 { get; set; }
        public string CorrienteLi2Co31 { get; set; }
        public string Descipcion { get; set; }
        public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<ConsLi2Co3> ConsLi2Co3 { get; set; }
        public virtual ICollection<ConsLitioLiCo3mensual> ConsLitioLiCo3mensual { get; set; }
    }
}
