using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class CatalogoTablasModel : ModelBase
    {
        [Required] public int IdCatalogoTablas { get; set; }
        public string Tabla { get; set; }
        public string Corriente { get; set; }
        public string VistaAsociada { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Alias { get; set; }
    }
}
