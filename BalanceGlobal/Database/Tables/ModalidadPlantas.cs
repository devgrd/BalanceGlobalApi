using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ModalidadPlantas
    {
        public ModalidadPlantas()
        {
            ProdyDespSdeAconsProdK = new HashSet<ProdyDespSdeAconsProdK>();
            ProdyDespSdeAconsProdK1 = new HashSet<ProdyDespSdeAconsProdK1>();
        }

        public int IdModalidadPlantas { get; set; }
        public string ModalidadPlanta { get; set; }
        public string Descripcion { get; set; }
        public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<ProdyDespSdeAconsProdK> ProdyDespSdeAconsProdK { get; set; }
        public virtual ICollection<ProdyDespSdeAconsProdK1> ProdyDespSdeAconsProdK1 { get; set; }
    }
}
