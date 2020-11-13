using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class CategoriaConsumoAgua
    {
        public int IdCategoriaConsumoAgua { get; set; }
        public string CategoriasConsumoAgua { get; set; }
        public string Descripcion { get; set; }
        public int? IdFaenas { get; set; }
        public int? IdSistemasSubsistemas { get; set; }
        public bool Activo { get; set; }
        public string GrupoReporte { get; set; }
        public string SuperGrupoReporte { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
