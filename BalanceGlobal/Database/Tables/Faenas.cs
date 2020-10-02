using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Faenas
    {
        public Faenas()
        {
            CategoriaConsumoAgua = new HashSet<CategoriaConsumoAgua>();
            FaenasSistemas = new HashSet<FaenasSistemas>();
        }

        public int IdFaenas { get; set; }
        public string Faena { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<CategoriaConsumoAgua> CategoriaConsumoAgua { get; set; }
        public virtual ICollection<FaenasSistemas> FaenasSistemas { get; set; }
    }
}
