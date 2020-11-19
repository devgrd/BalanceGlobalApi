using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using AutoMapper.Configuration.Annotations;

namespace BalanceGlobal.Models
{
    public class WorkflowItemModel : ModelBase
    {

        [Required] public int IdWorkflowItem { get; set; }
        public string NombreCategoria { get; set; }
        public string Alias { get; set; }
        [Required] public int Jerarquia { get; set; }
        public int? IdCategoriaPadre { get; set; }
        public int? OrdenCategoriaPadre { get; set; }
        [Ignore]
        public bool? SoloLectura { get; set; }
        public string Icono { get; set; }

    }
}
