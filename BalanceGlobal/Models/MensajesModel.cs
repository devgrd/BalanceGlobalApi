using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class MensajesModel : ModelBase
    {
        [Required] public int IdMensajes { get; set; }
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }
        public string Tipo { get; set; }
        public string Idioma { get; set; }
        [Required] public int Codigo { get; set; }
    }
}
