using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class CategoriaConsumoAguaModel : ModelBase
    {

        [Required] public int IdCategoriaConsumoAgua { get; set; }
        public string CategoriaConsumoAgua1 { get; set; }
        public string Descripcion { get; set; }
        public int? IdFaenas { get; set; }
        public int? IdSistemas { get; set; }
        public int? IdSistemasSubsistemas { get; set; }
        [Required] public bool Activo { get; set; }
        public string GrupoReporte { get; set; }
        public string SuperGrupoReporte { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
