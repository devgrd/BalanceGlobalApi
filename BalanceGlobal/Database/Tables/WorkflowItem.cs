using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class WorkflowItem
    {
        public WorkflowItem()
        {
            DetallePerfil = new HashSet<DetallePerfil>();
        }

        public int IdWorkflowItem { get; set; }
        public string NombreCategoria { get; set; }
        public string Alias { get; set; }
        public int Jerarquia { get; set; }
        public int? IdCategoriaPadre { get; set; }
        public int? OrdenCategoriaPadre { get; set; }
        public string Icono { get; set; }

        public virtual ICollection<DetallePerfil> DetallePerfil { get; set; }
    }
}
