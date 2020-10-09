using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class EventosModel : ModelBase
    {

        [Required] public int IdEventos { get; set; }
        public string Evento { get; set; }
        public string Descripcion { get; set; }
        [Required] public bool Acivo { get; set; }

    }
}
