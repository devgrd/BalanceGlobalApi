using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DetallePerfil
    {
        public int IdDetallePerfil { get; set; }
        public int IdWorkflowItem { get; set; }
        public int IdPerfilUsuario { get; set; }
        public bool SoloLectura { get; set; }

        public virtual PerfilesUsuario IdPerfilUsuarioNavigation { get; set; }
        public virtual WorkflowItem IdWorkflowItemNavigation { get; set; }
    }
}
