using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ModalidadPci
    {
        public ModalidadPci()
        {
            Pcimodos = new HashSet<Pcimodos>();
        }

        public int IdModalidadPci { get; set; }
        public string ModalidadPci1 { get; set; }
        public string Descripcion { get; set; }
        public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<Pcimodos> Pcimodos { get; set; }
    }
}
