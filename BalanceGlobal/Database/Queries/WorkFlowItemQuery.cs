using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalanceGlobal.Database.Queries
{
    public class WorkFlowItemQuery
    {
        [Key]
        public int IdWorkflowItem { get; set; }
        public string NombreCategoria { get; set; }
        public string Alias { get; set; }
        public int Jerarquia { get; set; }
        public int? IdCategoriaPadre { get; set; }
        public int? OrdenCategoriaPadre { get; set; }
        public string Icono { get; set; }
        public bool SoloLectura { get; set; }
    }
}
