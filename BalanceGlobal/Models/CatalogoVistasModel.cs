using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class CatalogoVistasModel : ModelBase
    {
        [Required] public int IdCatalogoVistas { get; set; }
        public string Vista { get; set; }
        public string Descripcion { get; set; }
        public string Origen { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
